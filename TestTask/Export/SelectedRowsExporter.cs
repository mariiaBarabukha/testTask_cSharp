using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestTask.Export
{
    abstract class SelectedRowsExporter : Exporter, IExporter
    {       
        
        public void Export()
        {
            _export();
        }

        protected void _export()
        {
            var spreadsheetControl = Model.GetModel().spreadsheetControl;
            IWorkbook workbook = spreadsheetControl.Document;
            Worksheet sheet = workbook.Worksheets.ActiveWorksheet;

            spreadsheetControl.BeginUpdate();
            Worksheet tempWorksheet = workbook.Worksheets.Add();

            CopySubRanges(sheet, tempWorksheet);
            workbook.Options.Export.Csv.Worksheet = tempWorksheet.Name;
            string fileName = Model.GetModel().filePath;
            workbook.SaveDocument(fileName, format);

            workbook.Worksheets.Remove(tempWorksheet);
            spreadsheetControl.EndUpdate();
            MessageBox.Show("Saved");
        }

        private void CopySubRanges(Worksheet sourceWorksheet, Worksheet targetWorksheet)
        {
            IList<CellRange> rangeCollection = sourceWorksheet.GetSelectedRanges();
            int rowIndex = 0;
            foreach (var item in rangeCollection)
            {
                
                if (item.ColumnCount < 16384)
                {
                    continue;
                }

                CellRange targetRange;
                targetRange = targetWorksheet.Range.FromLTRB(0, rowIndex, item.ColumnCount - 1, rowIndex);
                targetRange.CopyFrom(item);
                rowIndex = targetRange.BottomRowIndex + 1;
            }
        }
    }
}
