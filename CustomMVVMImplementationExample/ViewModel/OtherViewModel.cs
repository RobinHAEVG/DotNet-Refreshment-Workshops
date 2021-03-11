using CustomMVVMImplementationExample.Message;
using CustomMVVMImplementationExample.MVVM;

namespace CustomMVVMImplementationExample.ViewModel
{
    public class OtherViewModel : ViewModelBase
    {
        public OtherViewModel()
        {
            Messenger.Send(new ReloadMessage());
        }
    }
}
