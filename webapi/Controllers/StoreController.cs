using Microsoft.AspNetCore.Mvc;
using  webapi.Data;
namespace webapi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController] 
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepo _store ;
        public StoreController(IStoreRepo store )
        {
            _store = store;
        }
        [HttpGet]
        public ActionResult<string> GetCarById(int id)
        {
            return "";
        }

    }
}
