


using Mono_praksa1.Service;
using System.Net.Http;
using System.Web.Http;

namespace Mono_praksa1.Controllers
{
    public class CharacterController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            CharacterService service = new CharacterService();

            return Request.CreateResponse();
        }
    }
}
        
            
         
    
