using System;
namespace to_do.Decorators
{
    public class TaskPastDueDecorator : AbstractTaskDecorator
    {
        public TaskPastDueDecorator(TaskComponent wrappee) : base(wrappee) {}

        new public void Style()
        {
            base.Style();
        }
    }
}
