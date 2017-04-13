using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace QuotaTthrotling.Controllers
{
    public class QuotaController : ApiController
    {
        [Route("api/quota/test")]
        [HttpGet()]
        public string Test()
        {           
            return "Shown Successfully";
        }

    }
}
