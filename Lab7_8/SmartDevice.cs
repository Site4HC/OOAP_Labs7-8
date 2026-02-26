using System;

namespace SmartRoomApp.Core
{
    public class SmartDevice
    {
        public string Name { get; }
        public bool IsOn { get; private set; }

        public SmartDevice(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Назва пристрою не може бути порожньою.");

            Name = name;
            IsOn = false; 
        }

        internal void SetState(bool state)
        {
            IsOn = state;
            Console.WriteLine($"[Система] {Name} тепер {(IsOn ? "Увімкнено" : "Вимкнено")}");
        }
    }
}