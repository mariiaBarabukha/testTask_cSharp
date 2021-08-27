using Ninject.Modules;
using TestTask.ViewModels;

namespace TestTask
{
    class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IViewModel>().To<TableViewModel>();
            Bind<IFileSaver>().To<FileSaver>();
        }
    }
}
