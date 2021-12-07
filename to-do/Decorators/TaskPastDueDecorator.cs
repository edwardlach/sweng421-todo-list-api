using System;
namespace to_do.Decorators
{
    public class TaskPastDueDecorator : TaskDecorator
    {
        public TaskPastDueDecorator(TaskComponent wrappee) : base(wrappee) {}

        new public void Style()
        {
            throw new NotImplementedException();
        }
    }
}
