using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomMVVMImplementationExample.MVVM
{
    public class RelayCommand : ICommand
    {
        private Action<object?> ex;
        private Func<object?, bool> canEx;

        public RelayCommand(Action<object?> paramEx, Func<object?, bool> paramCanEx = null)
        {
            if (paramEx == null)
                throw new Exception("execute method cannot be null");

            this.ex = paramEx;
            this.canEx = paramCanEx;
        }

        public bool CanExecute(object? parameter)
        {
            if (this.canEx != null)
                return this.canEx(parameter);

            return true;
        }

        public void Execute(object? parameter)
        {
            if (this.CanExecute(parameter))
                this.ex(parameter);
        }

        public event EventHandler? CanExecuteChanged;
    }
}
