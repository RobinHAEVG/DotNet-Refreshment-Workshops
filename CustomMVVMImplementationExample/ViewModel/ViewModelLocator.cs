using CustomMVVMImplementationExample.MVVM;

namespace CustomMVVMImplementationExample.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceContainer.Register<MainWindowViewModel>();
        }

        public MainWindowViewModel MainWindowViewModel =>
            ServiceContainer.GetInstance<MainWindowViewModel>();
    }
}
