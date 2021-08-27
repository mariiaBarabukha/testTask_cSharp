using DevExpress.Spreadsheet;
using DevExpress.Xpf.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestTask.Export
{
    class Exporter
    {
        private IExporter exporter;

        protected DocumentFormat format;
        internal IExporter iExporter { get => exporter; set => exporter = value; }

        public Exporter(IExporter exporter)
        {
            this.exporter = exporter;
        }

        public Exporter() { }

        public void Export()
        {
            exporter.Export();
        }

    

    }

    public interface IExporter
    {
        void Export();
    }
}
