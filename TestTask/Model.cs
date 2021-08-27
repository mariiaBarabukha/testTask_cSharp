using DevExpress.Xpf.Spreadsheet;

namespace TestTask
{
    class Model
    {
        public SpreadsheetControl spreadsheetControl;
        public string filePath = "";

        public string[] formats =
        { 
            "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml",
            "Text documents (.txt)|*.txt" 
        };
        //public string[] findExtenction =
        //    {
        //     ,
            
        //    };

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
