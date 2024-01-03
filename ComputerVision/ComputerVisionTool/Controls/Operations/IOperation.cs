namespace ComputerVisionTool.Controls.Operations
{
    public interface IOperation
    {
        public CVToolsForm ContainerForm { get; set; }

        public void UpdateAll();
    }
}