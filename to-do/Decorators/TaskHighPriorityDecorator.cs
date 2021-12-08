using System;
namespace to_do.Decorators
{
    public class TaskHighPriorityDecorator : AbstractTaskDecorator
    {
        public TaskHighPriorityDecorator(TaskComponent wrappee) : base(wrappee) {}

        new public void Style()
        {
            base.Style();
        }
    }
}
