using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Command
{
    class ModifyPrice
    {
        List<ICommand> _commands;
        ICommand _command;

        public ModifyPrice()
        {
            _commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            _commands.Add(_command);
            _command.ExecuteAction();
        }

        public void SetCommandAndInvoke(ICommand command)
        {
            SetCommand(command);
            Invoke();
        }

    }
}
