using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pis
{
    public class ExceptionToFile
    {
        public static void SaveExceptionToDesktop(Exception ex, string prefix = "error_log")
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Генерируем уникальное имя файла с датой и временем
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = $"{prefix}_{timestamp}.txt";
            string filePath = Path.Combine(desktopPath, fileName);

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

            // Добавляем информацию о сборке
            errorInfo.AppendLine("\n--- Сведения о сборке ---");
            errorInfo.AppendLine($"Версия ОС: {Environment.OSVersion}");
            errorInfo.AppendLine($"Версия .NET: {Environment.Version}");
            errorInfo.AppendLine($"Имя машины: {Environment.MachineName}");
            errorInfo.AppendLine($"Пользователь: {Environment.UserName}");

            errorInfo.AppendLine(new string('=', 50));
            File.WriteAllText(filePath, errorInfo.ToString(), Encoding.UTF8);
            Console.WriteLine($"Файл сохранен: {filePath}");
        }
    }
}
