using ComputerVisionTool.Controls.Operations;

namespace ComputerVisionTool
{
    public static class TabManager
    {
        public const int DefaultWidth = 800;
        public const int DefaultHeight = 600;
        public const int DefaultX = 175;
        public const int DefaultY = 0;
        public const int OperationSpacing = 15;

        public static Dictionary<string, TabPage> TabPageByName { get; private set; }
        public static TabControl TabControl { get; private set; }

        private static CVToolsForm parent;
        private static int availableID;

        public static void Load(CVToolsForm parent)
        {
            TabManager.parent = parent;

            TabPageByName = new();
            TabControl = new()
            {
                Location = new Point(DefaultX, DefaultY),
                Width = DefaultWidth,
                Height = DefaultHeight,
            };
            AddPage();

            parent.Controls.Add(TabControl);
        }

        public static void AddPage()
        {
            var newTab = new TabPage()
            {
                Text = "New Tab",
                Name = (availableID++).ToString(),
                AutoScroll = true
            };
            newTab.Controls.Add(new BaseOp(containerForm: parent));
            TabControl.Controls.Add(newTab);
        }

        public static void AddOperation(Type operationType)
        {
            var previousControl = (UserControl)TabControl.SelectedTab.Controls[^1];

            var newOp = (UserControl)(Activator.CreateInstance(operationType, new object[]
            {
                /* parent: */ TabControl.SelectedTab,
                /* location: */ new Point(0, previousControl.Bottom + OperationSpacing),
                /* containerForm: */ parent
            }) ?? throw new ArgumentException($"Could not create new operation of type {operationType.Name}"));

            TabControl.SelectedTab.Controls.Add(newOp);
        }

        public static void UpdateAll()
        {
            foreach(TabPage tabPage in TabControl.TabPages)
            {
                foreach (IOperation control in tabPage.Controls)
                {
                    control.UpdateAll();
                }
            }
        }
    }
}
