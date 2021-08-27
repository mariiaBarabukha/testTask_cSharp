using DevExpress.Spreadsheet;
using DevExpress.Xpf.Spreadsheet;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Export;

namespace TestTask.ViewModels
{
    class TableViewModel : IViewModel
    {
        
        private IExporter[] exporters;
        private Exporter _exp = new Exporter();

        

        public DelegateCommand ExportCSV { get; set; }
        public DelegateCommand ExportTXT { get; set; }

        public IFileSaver iFileSaver { get; set; }

        public TableViewModel(IFileSaver fileSaver)
        {
            iFileSaver = fileSaver;
            exporters = new IExporter[2];
            exporters[0] = new CSVSelectedRowsExporter();
            exporters[1] = new TXTSelectedRowsExporter();
            ExportCSV = new DelegateCommand(_exportCSV);
            ExportTXT = new DelegateCommand(_exportTXT);
        }
        private void _exportCSV()
        {
            _export(0);
        }

        private void _exportTXT()
        {
            _export(1);
        }

        private void _export(int i)
        {
            iFileSaver.Save(i);
            _exp.iExporter = exporters[i];
            _exp.Export();
        }

        

    }
}
