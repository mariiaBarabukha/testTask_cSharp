
using System.IO;

namespace TestTask
{
    class FileSaver : IFileSaver
    {
        public bool Save(int i)
        {
            var format = Model.GetModel().formats[i];
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.InitialDirectory = "";
            dialog.Filter = Model.GetModel().findExtenction[i];
            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;
                //if (!File.Exists(path))
                //{
                //    path += ('.'+format);
                //}
                Model.GetModel().filePath = path;
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
