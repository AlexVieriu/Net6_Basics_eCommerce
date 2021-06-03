using _40_LifeTimeManagement_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace _40_LifeTimeManagement_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LifeCycleController : ControllerBase
    {
        private readonly ITransient _transient1;
        private readonly ITransient _transient2;
        private readonly IScoped _scoped1;
        private readonly IScoped _scoped2;
        private readonly ISingleton _singleton1;
        private readonly ISingleton _singleton2;

        public LifeCycleController(ITransient transient1,
                                   ITransient transient2,
                                   IScoped scoped1,
                                   IScoped scoped2,
                                   ISingleton singleton1,
                                   ISingleton singleton2)
        {
            _transient1 = transient1;
            _transient2 = transient2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
        } 


        [HttpGet]
        public IActionResult GetGuid()
        {
            var tran1 = _transient1.GenerateGuid();
            var tran2 = _transient2.GenerateGuid();
            var scop1 = _scoped1.GenerateGuid();
            var scop2 = _scoped2.GenerateGuid();
            var single1 = _singleton1.GenerateGuid();
            var single2 = _singleton2.GenerateGuid();


            return Ok(new { tran1 , tran2, scop1, scop2, single1, single2});
        }
    }
}
