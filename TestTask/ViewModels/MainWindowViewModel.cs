using Ninject;
using System.Reflection;

namespace TestTask.ViewModels
{
    class MainWindowViewModel
    {
        public MainWindowViewModel() { }       
        public object Content
        {
            get 
            {
                var kernel = new StandardKernel(new NinjectBindings());
                kernel.Load(Assembly.GetExecutingAssembly());
                var viewModel = kernel.Get<IViewModel>();
                var fileSever = kernel.Get<IFileSaver>();
                viewModel.iFileSaver = fileSever;
                return new TableView(viewModel);
                
            }
            
        }
       
    }
}
