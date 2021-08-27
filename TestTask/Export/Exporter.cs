using DevExpress.Spreadsheet;

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
