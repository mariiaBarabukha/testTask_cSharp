namespace TestTask
{
    class FileSaver : IFileSaver
    {
        public bool Save(int i)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.InitialDirectory = "";
            dialog.Filter = Model.GetModel().formats[i];
            if (dialog.ShowDialog() == true)
            {
                string path = dialog.FileName;
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
