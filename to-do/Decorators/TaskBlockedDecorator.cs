using System;
namespace to_do.Decorators
{
    public class TaskBlockedDecorator : TaskDecorator
    {
        public TaskBlockedDecorator(TaskComponent wrappee) : base(wrappee) {}

        new public void Style()
        {
            throw new NotImplementedException();
        }
    }
}
