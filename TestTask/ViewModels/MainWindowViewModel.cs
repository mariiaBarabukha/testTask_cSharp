using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
