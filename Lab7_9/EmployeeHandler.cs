using System;

namespace JournalEditorial.Core
{
    public abstract class EmployeeHandler
    {
        protected EmployeeHandler? NextHandler;

        public void SetNext(EmployeeHandler next)
        {
            NextHandler = next;
        }

        public virtual string Handle(EditorialTask task)
        {
            if (task == null) throw new ArgumentNullException(nameof(task));
            return NextHandler?.Handle(task) ?? "Помилка: Спеціаліста для такої задачі в редакції немає.";
        }
    }
}