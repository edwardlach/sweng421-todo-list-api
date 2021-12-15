using System;
using System.Windows.Forms;

namespace to_do.Decorators
{
    public abstract class AbstractTaskDecorator : ITaskComponent
    {
        protected TaskComponent wrappee;

        public AbstractTaskDecorator(TaskComponent wrappee)
        {
            this.wrappee = wrappee;
        }

        public virtual ListViewItem ToListViewItem()
        {

            return this.wrappee.ToListViewItem();
        }
        
        
    }
}
