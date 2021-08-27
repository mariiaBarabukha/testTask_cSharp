using DevExpress.Spreadsheet;

namespace TestTask.Export
{
    class CSVSelectedRowsExporter : SelectedRowsExporter
    {
        
        public CSVSelectedRowsExporter()
        {
            format = DocumentFormat.Csv;
        } 

        
    }

}
