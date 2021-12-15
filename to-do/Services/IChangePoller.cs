using System;
using System.Threading.Tasks;

namespace to_do.Services
{
    public interface IChangePoller
    {
        void PollForChanges(object state);
    }
}
