using System;
using to_do_api.Services.@abstract;
using to_do_api.Models;
using to_do_api.DAOs.@abstract;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using System.Threading;

namespace to_do_api.Services.impl.@abstract
{
    public abstract class AbstractReadService <MODEL> : BackgroundService, IReadService <MODEL>  where MODEL : IdentifiableEntity
    {
        protected IAbstractReadDAO<MODEL> dao;
        
        protected AbstractReadService(IAbstractReadDAO<MODEL> dao)
        {
            this.dao = dao;
        }

        public MODEL Read(int id)
        {
            return this.dao.Read(id);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}
