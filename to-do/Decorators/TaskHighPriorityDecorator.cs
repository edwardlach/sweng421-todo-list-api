using System;
namespace to_do.Decorators
{
    public class TaskHighPriorityDecorator : TaskDecorator
    {
        public TaskHighPriorityDecorator(TaskComponent wrappee) : base(wrappee) {}

        new public void Style()
        {
            throw new NotImplementedException();
        }
    }
}
