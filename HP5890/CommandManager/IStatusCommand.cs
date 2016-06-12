using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HP5890.CommandManager
{
    public interface IStatusCommand
    {
        void Execute(object parameter);
        bool CanExecute(object parameter);
        //event EventHandler CanExecuteChanged;
    }
}
