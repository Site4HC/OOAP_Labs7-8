using System;
using System.Collections.Generic;

namespace SmartRoomApp.Core
{
    public class RemoteControl
    {
        private readonly Stack<ICommand> _history = new Stack<ICommand>();

        public bool CanUndo => _history.Count > 0;

        public void ExecuteCommand(ICommand command)
        {
            if (command == null) throw new ArgumentNullException(nameof(command));

            try
            {
                command.Execute();
                _history.Push(command);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Центральний пульт: не вдалося виконати команду.", ex);
            }
        }

        public void Undo(int steps)
        {
            if (steps <= 0) return;

            if (_history.Count == 0)
                throw new InvalidOperationException("Історія команд порожня. Нічого відміняти.");

            for (int i = 0; i < steps && _history.Count > 0; i++)
            {
                try
                {
                    ICommand lastCommand = _history.Pop();
                    lastCommand.Undo();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Помилка під час відміни операції.", ex);
                }
            }
        }
    }
}