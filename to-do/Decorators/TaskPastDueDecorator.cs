using System;
using System.Drawing;
using System.Windows.Forms;
namespace to_do.Decorators
{
    public class TaskPastDueDecorator : AbstractTaskDecorator
    {
        public TaskPastDueDecorator(TaskComponent wrappee) : base(wrappee) {}

        public override ListViewItem ToListViewItem()
        {
            ListViewItem item = base.ToListViewItem();
            item.BackColor = Color.Red;
            return item;
        }
    }
}
