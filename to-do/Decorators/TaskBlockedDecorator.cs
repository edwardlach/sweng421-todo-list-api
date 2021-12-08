using System;
namespace to_do.Decorators
{
    public class TaskBlockedDecorator : AbstractTaskDecorator
    {
        public TaskBlockedDecorator(TaskComponent wrappee) : base(wrappee) {}

        new public void Style()
        {
            base.Style();
        }
    }
}
