namespace JournalEditorial.Core
{
    public sealed class DesignerHandler : EmployeeHandler
    {
        public override string Handle(EditorialTask task)
        {
            if (task.Type == TaskType.Design)
                return $"[Дизайнер] Опрацьовано: дизайн обкладинки для '{task.Title}' готовий.";

            return base.Handle(task);
        }
    }
}