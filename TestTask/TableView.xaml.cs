using System.Windows.Controls;
using TestTask.ViewModels;

namespace TestTask
{
    /// <summary>
    /// Interaction logic for TableView.xaml
    /// </summary>
    public partial class TableView : UserControl
    {
        IViewModel viewModel;
        public TableView(IViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
            DataContext = this.viewModel;
            Model.GetModel().spreadsheetControl = spreadsheetControl1;
        }
    }
}
