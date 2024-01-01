namespace ComputerVisionTool.Controls.Operations
{
    public partial class BaseOp : UserControl, IOperation
    {
        public OperationInfo OpInfo { get => OperationInfo.BaseOperationInfo; }
        public CVToolsForm ContainerForm { get; set; }

        public BaseOp(CVToolsForm containerForm)
        {
            ContainerForm = containerForm;

            InitializeComponent();

            Location = Point.Empty;
        }

        public void UpdateAll() { }
    }
}
