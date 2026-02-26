using System;

namespace JournalEditorial.Core
{
    public sealed class EditorialTask
    {
        public string Title { get; }
        public TaskType Type { get; }

        public EditorialTask(string title, TaskType type)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Назва задачі не може бути порожньою.");
            Title = title;
            Type = type;
        }
    }
}