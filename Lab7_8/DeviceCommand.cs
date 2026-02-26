using System;

namespace SmartRoomApp.Core
{
    public sealed class DeviceCommand : ICommand
    {
        private readonly SmartDevice _device;
        private readonly bool _newState;
        private bool _previousState;
        private bool _hasExecuted = false;

        public string Name => $"{_device.Name} -> {(_newState ? "Вкл" : "Викл")}";

        public DeviceCommand(SmartDevice device, bool newState)
        {
            _device = device ?? throw new ArgumentNullException(nameof(device), "Пристрій не знайдено.");
            _newState = newState;
        }

        public void Execute()
        {
            try
            {
                _previousState = _device.IsOn;
                _device.SetState(_newState);
                _hasExecuted = true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Помилка виконання команди для {_device.Name}", ex);
            }
        }

        public void Undo()
        {
            if (!_hasExecuted)
                throw new InvalidOperationException("Неможливо відмінити команду, яка ще не була виконана.");

            _device.SetState(_previousState);
            _hasExecuted = false;
        }
    }
}