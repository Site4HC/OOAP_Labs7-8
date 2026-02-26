namespace JournalEditorial.Core
{
    public sealed class LayoutMakerHandler : EmployeeHandler
    {
        public override string Handle(EditorialTask task)
        {
            if (task.Type == TaskType.Layout)
                return $"[Макетувальник] Опрацьовано: макет для '{task.Title}' сформовано.";

            return base.Handle(task);
        }
    }
}