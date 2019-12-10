using APICep.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICep.Controllers
{
    [Route("api[Controller]")]
    [ApiController]
    public class CepController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public readonly ICepRepository cepRepository;               
    }
}
