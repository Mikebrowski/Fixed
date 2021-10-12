using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodeBokerWebApi.Controllers
{
    public class RegisteredBookController
    {
        [ApiController]
        [Route("[controller]")]
        public class RegisteredBookController : ControllerBase
        {
            private readonly InterfaceGoodBooksFunctions _GoodBooksFunctionskServices;
            public RegisteredBookController(GoodBooksFunctions )
            {
              
            }

            [HttpGet]
            public IActionResult GetRegisteredBook()
            {
                return Ok(GetRegisteredBook.GetRegisteredBook());
            }

            [HttpPost]
            public IActionResult addRegisteredBook(RegisteredBook registeredBook)
            {
                _bookServices.AddRegisteredBook(registeredBook);
                return CreatedAtRoute("GetBook", new { id = RegisteredBook.Id }, registeredBook);
            }


        }
    }

}
