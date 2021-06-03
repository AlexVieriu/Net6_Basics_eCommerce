using _40_LifeTimeManagement_BlazorClient.Services;
using System;

namespace _40_LifeTimeManagement_BlazorClient.Contracts
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
