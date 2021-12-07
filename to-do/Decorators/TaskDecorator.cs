using System;
namespace to_do.Decorators
{
    public class TaskDecorator : ITaskComponent
    {
        protected TaskComponent wrappee;

        public TaskDecorator(TaskComponent wrappee)
        {
            this.wrappee = wrappee;
        }

        public void Style()
        {
            throw new NotImplementedException();
        }
    }
}
