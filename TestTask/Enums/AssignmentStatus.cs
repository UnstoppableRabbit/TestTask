using System.ComponentModel;

namespace TestTask.Enums
{
    public enum AssignmentStatus : byte
    {
        [Description("К выполнению")]
        ToDo,

        [Description("В работе")]
        InProgress,

        [Description("Выполнено")]
        Finished
    }
}
