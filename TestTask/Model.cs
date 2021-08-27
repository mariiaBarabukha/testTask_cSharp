using DevExpress.Xpf.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Model
    {
        public SpreadsheetControl spreadsheetControl;
        public string filePath = "";

        public string[] formats = { "csv", "txt" };

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
