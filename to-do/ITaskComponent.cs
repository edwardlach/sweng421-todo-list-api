using System;
using System.Windows.Forms;

namespace to_do
{
    public interface ITaskComponent
    {
        ListViewItem ToListViewItem();

        
    }
}
