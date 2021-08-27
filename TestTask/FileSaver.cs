using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class FileSaver : IFileSaver
    {
        public bool Save(int i)
        {
            var format = Model.GetModel().formats[i];
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.InitialDirectory = "";
            dialog.Filter = "*."+format+"|*.this.directory";
            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;
                path = path.Replace(".this.directory", "");
                Model.GetModel().filePath = path + '.' + format;
                return true;
            }
            return false;
        }
    }

    public interface IFileSaver
    {
        bool Save(int i);
    }
}
