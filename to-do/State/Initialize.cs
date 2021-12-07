using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do.Services;

namespace to_do.State
{
    internal class Initialize
    {
        Store store;
        IToDoListService listService;
        public Initialize(Store store, IToDoListService listService)
        {
            this.store = store;       
            this.listService = listService;
        }

        public void Run()
        {
            this.listService.Read(9).Result.Tasks.Collection.ForEach(t =>
            {
                this.store.ToDoTaskState.AddTo(t);
            });
        }

    }
}
