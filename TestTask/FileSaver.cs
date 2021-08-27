using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class FileSaver : IFileSaver
    {
        public void Save(int i)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.InitialDirectory = "";
            dialog.FileName = "select";
            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;
                path = path.Replace("\\select.this.directory", "");
                path = path.Replace(".this.directory", "");
                Model.GetModel().filePath = path + '.' + Model.GetModel().formats[i];
            }
        }
    }

    public interface IFileSaver
    {
        void Save(int i);
    }
}
