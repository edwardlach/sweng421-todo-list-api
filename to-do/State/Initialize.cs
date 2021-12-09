using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do.Services;
using to_do.DTOs;

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
            ToDoListDTO.ToDoListResponse response = this.listService.Read(9).Result;
            this.store.ToDoListState.SetActive(response);
            this.store.UserState.SetActive(response.Creator);

            response.Tasks.Collection.ForEach(t =>
            {
                this.store.ToDoTaskState.AddTo(t);
            });

        }

    }
}
