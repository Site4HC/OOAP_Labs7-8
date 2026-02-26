namespace JournalEditorial.Core
{
    public sealed class EditorHandler : EmployeeHandler
    {
        public override string Handle(EditorialTask task)
        {
            if (task.Type == TaskType.Edits)
                return $"[Редактор] Опрацьовано: правки для статті '{task.Title}' внесені.";

            return base.Handle(task);
        }
    }
}