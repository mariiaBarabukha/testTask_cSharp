using DevExpress.Spreadsheet;

namespace TestTask.Export
{
    class TXTSelectedRowsExporter : SelectedRowsExporter
    {
        public TXTSelectedRowsExporter()
        {
            format = DocumentFormat.Text;
        }
    }
}
