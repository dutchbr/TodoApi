using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TodoApi.classes;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcoController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        public EcoController(IOptions<AppSettings> appSettings)
        {
            this._appSettings = appSettings.Value;
        }
        [HttpGet]
        //https://localhost:44327/api/Eco?eco=12
        public string Eco(string eco)
        {
            return eco;
        }

        [HttpGet]
        [Route("GetSettings")]
        public string GetSettings()
        {
            return _appSettings.ApplicationName + " " + _appSettings.StringConnection; 
        }

    }
}