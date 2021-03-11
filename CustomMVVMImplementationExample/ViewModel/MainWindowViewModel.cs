using System.Windows;
using CustomMVVMImplementationExample.Message;
using CustomMVVMImplementationExample.MVVM;

namespace CustomMVVMImplementationExample.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string myProp;

        public string MyProp
        {
            get => this.myProp;
            set => base.Set(ref this.myProp, value);
        }

        public MainWindowViewModel()
        {
            //base.Set(ref this.myProp, "hallo", "MyProp");
            //this.MyProp = "Hallo";

            Messenger.Register<ReloadMessage>(this.ReloadData);
        }

        private void ReloadData(object obj)
        {
            if (obj is not ReloadMessage message)
                return;

            MessageBox.Show("Message received!");
        }
    }
}
