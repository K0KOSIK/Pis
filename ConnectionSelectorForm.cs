using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis
{
    public partial class ConnectionSelectorForm : Form
    {
        public string SelectedConnection { get; private set; }

        public ConnectionSelectorForm()
        {
            InitializeComponent();
            var config = AppConfig.Load();

            foreach (var connection in config.ConnectionStrings.Keys)
            {
                cmbConnections.Items.Add(connection);
            }

            cmbConnections.SelectedItem = config.DefaultConnection;

            MenuStrip menu = new MenuStrip();
            menu.BackColor = SystemColors.ActiveCaption;
            menu.ForeColor = SystemColors.ActiveCaptionText;
            menu.RenderMode = ToolStripRenderMode.Professional;

            menu.Renderer = new CustomMenuRenderer();

            ApplyColorsToMenuItems(menu.Items);
            ToolStripMenuItem toolsMenu = new ToolStripMenuItem("Инструменты");

            toolsMenu.BackColor = SystemColors.ActiveCaption;
            toolsMenu.ForeColor = SystemColors.ActiveCaptionText;
            // Пункт для открытия папки данных
            ToolStripMenuItem openDataItem = new ToolStripMenuItem("Открыть папку данных", null,
                (s, e) => OpenAppDataFolder());
            openDataItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;

            toolsMenu.DropDownItems.Add(openDataItem);
            menu.Items.Add(toolsMenu);

            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
        }
        private void ApplyColorsToMenuItems(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                item.BackColor = SystemColors.ActiveCaption;
                item.ForeColor = SystemColors.ActiveCaptionText;

                if (item is ToolStripMenuItem menuItem)
                {
                    menuItem.DropDown.BackColor = SystemColors.ActiveCaption;
                    menuItem.DropDown.ForeColor = SystemColors.ActiveCaptionText;

                    if (menuItem.HasDropDownItems)
                    {
                        ApplyColorsToMenuItems(menuItem.DropDownItems);
                    }
                }
            }
        }

        private class CustomMenuRenderer : ToolStripProfessionalRenderer
        {
            public CustomMenuRenderer() : base(new CustomColorTable()) { }

            // Переопределяем отрисовку текста
            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = SystemColors.ActiveCaptionText;
                base.OnRenderItemText(e);
            }

            // Переопределяем отрисовку стрелочек в подменю
            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
            {
                e.ArrowColor = SystemColors.ActiveCaptionText;
                base.OnRenderArrow(e);
            }
        }

        private class CustomColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected => SystemColors.ActiveCaption;

            public override Color MenuItemSelectedGradientBegin => SystemColors.ActiveCaption;
            public override Color MenuItemSelectedGradientEnd => SystemColors.ActiveCaption;

            public override Color MenuItemBorder => SystemColors.ActiveCaption;

            public override Color MenuBorder => SystemColors.ActiveCaption;

            public override Color MenuItemPressedGradientBegin => SystemColors.ActiveCaption;
            public override Color MenuItemPressedGradientEnd => SystemColors.ActiveCaption;

            public override Color ToolStripDropDownBackground => SystemColors.ActiveCaption;

            public override Color SeparatorDark => SystemColors.ActiveCaptionText;
            public override Color SeparatorLight => SystemColors.ActiveCaptionText;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SelectedConnection = cmbConnections.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ConnectionSelectorForm_Load(object sender, EventArgs e)
        {

        }

        private void ConnectionSelectorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.O)
            {
                OpenAppDataFolder();
                e.Handled = true; // Предотвращаем дальнейшую обработку
            }
        }
        private void OpenAppDataFolder()
        {
            try
            {
                // Получаем путь к AppData\Roaming
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                // Получаем имя приложения
                string appName = Assembly.GetEntryAssembly()?.GetName().Name ?? "Automation";

                // Формируем полный путь к папке приложения
                string appFolder = Path.Combine(appDataPath, appName);

                // Проверяем существование папки
                if (!Directory.Exists(appFolder))
                {
                    Directory.CreateDirectory(appFolder);
                }

                // Открываем папку в проводнике
                Process.Start("explorer.exe", $"\"{appFolder}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия папки: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
