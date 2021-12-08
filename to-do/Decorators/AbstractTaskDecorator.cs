using System;
namespace to_do.Decorators
{
    public abstract class AbstractTaskDecorator : ITaskComponent
    {
        protected TaskComponent wrappee;

        public AbstractTaskDecorator(TaskComponent wrappee)
        {
            this.wrappee = wrappee;
        }

        public void Style()
        {
            this.wrappee.Style();
        }
    }
}
