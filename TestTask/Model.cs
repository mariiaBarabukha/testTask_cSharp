using DevExpress.Xpf.Spreadsheet;

namespace TestTask
{
    class Model
    {
        public SpreadsheetControl spreadsheetControl;
        public string filePath = "";

        public string[] formats = { "csv", "txt" };
        public string[] findExtenction =
            {
            "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml" ,
            "Text documents (.txt)|*.txt"
            };

        private Model() { }
        private static Model model;
        public static Model GetModel()
        {
            if (model == null)
            {
                model = new Model();
            }
            return model;
        }
    }
}
