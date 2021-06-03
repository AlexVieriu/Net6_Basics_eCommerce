using System;
using _40_LifeTimeManagement_BlazorServer.Services;

namespace _40_LifeTimeManagement_BlazorServer.Contracts
{
    public class LifeCycle : ITransient, IScoped, ISingleton
    {
        private string _guid;
        public LifeCycle()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}
