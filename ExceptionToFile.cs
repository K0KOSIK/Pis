using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pis
{
    public class ExceptionToFile
    {
        public static void SaveExceptionToAppData(Exception ex, string prefix = "error_log")
        {
            try
            {
                // Получаем путь к AppData\Roaming
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                // Название приложения (можно брать из Assembly)
                string appName = Assembly.GetEntryAssembly()?.GetName().Name ?? "Automation";

                // Путь к папке логов
                string logFolder = Path.Combine(appDataPath, appName, "logs");

                // Создаем папку, если не существует
                if (!Directory.Exists(logFolder))
                {
                    Directory.CreateDirectory(logFolder);
                }

                // Генерируем уникальное имя файла
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"{prefix}_{timestamp}.txt";
                string filePath = Path.Combine(logFolder, fileName);

                // Формируем информацию об ошибке
                StringBuilder errorInfo = new StringBuilder();
                errorInfo.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
                errorInfo.AppendLine($"Тип ошибки: {ex.GetType().Name}");
                errorInfo.AppendLine($"Сообщение: {ex.Message}");
                errorInfo.AppendLine($"Стек вызовов: {ex.StackTrace}");

                // Добавляем информацию о внутренних исключениях
                Exception innerEx = ex.InnerException;
                int innerCount = 1;
                while (innerEx != null)
                {
                    errorInfo.AppendLine($"\n--- Внутреннее исключение #{innerCount++} ---");
                    errorInfo.AppendLine($"Тип: {innerEx.GetType().Name}");
                    errorInfo.AppendLine($"Сообщение: {innerEx.Message}");
                    errorInfo.AppendLine($"Стек: {innerEx.StackTrace}");
                    innerEx = innerEx.InnerException;
                }

                // Добавляем системную информацию
                errorInfo.AppendLine("\n--- Сведения о сборке ---");
                errorInfo.AppendLine($"Версия ОС: {Environment.OSVersion}");
                errorInfo.AppendLine($"Версия .NET: {Environment.Version}");
                errorInfo.AppendLine($"Имя машины: {Environment.MachineName}");
                errorInfo.AppendLine($"Пользователь: {Environment.UserName}");
                errorInfo.AppendLine($"Приложение: {appName}");
                errorInfo.AppendLine($"Версия приложения: {Assembly.GetEntryAssembly()?.GetName().Version}");
                errorInfo.AppendLine($"Рабочая папка: {Environment.CurrentDirectory}");

                errorInfo.AppendLine(new string('=', 50));

                // Сохраняем файл
                File.WriteAllText(filePath, errorInfo.ToString(), Encoding.UTF8);
                Console.WriteLine($"Файл лога сохранен: {filePath}");
            }
            catch (Exception fileEx)
            {
                // Резервное сохранение на рабочий стол
                try
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string backupPath = Path.Combine(desktopPath, $"error_backup_{Guid.NewGuid()}.txt");
                    File.WriteAllText(backupPath, $"Ошибка сохранения лога: {fileEx}\n\nОригинальная ошибка: {ex}", Encoding.UTF8);
                    Console.WriteLine($"Резервный файл сохранен: {backupPath}");
                }
                catch
                {
                    Console.WriteLine("Не удалось сохранить лог ни в AppData, ни на рабочий стол");
                }
            }
        }
    }
}
