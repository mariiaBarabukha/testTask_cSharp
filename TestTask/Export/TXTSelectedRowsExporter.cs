using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
