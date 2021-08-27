using DevExpress.Xpf.Core;
using TestTask.ViewModels;

namespace TestTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        MainWindowViewModel viewModel;

        public MainWindow()
        {
            viewModel = new MainWindowViewModel();
            InitializeComponent();
            this.Content = viewModel.Content;
            this.DataContext = viewModel;

        }

        
    }
}
