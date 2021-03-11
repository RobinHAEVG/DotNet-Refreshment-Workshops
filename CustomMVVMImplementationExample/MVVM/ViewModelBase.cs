using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomMVVMImplementationExample.MVVM
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Set<T>(ref T val, T newVal, [CallerMemberName] string propertyName = null)
        {
            val = newVal;
            this.OnPropertyChanged(propertyName);
        }
    }
}
