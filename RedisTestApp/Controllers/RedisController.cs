using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;

namespace RedisTestApp.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class RedisController : Controller
    {
        private readonly IEasyCachingProvider _provider;
        private readonly IEasyCachingProviderFactory _factory;

        public RedisController(IEasyCachingProviderFactory factory)
        {
            this._factory = factory;
            this._provider = this._factory.GetCachingProvider("redis1");
        }

        [HttpGet]
        public JsonResult Get()
        {
            //Set
            //_provider.Set("demo", "Mohamed Salah", TimeSpan.FromDays(1));

            // Get value by key
            var redisResult = _provider.Get<string>("demo");
            return Json(redisResult);
        }

        [Route("ShowMe")]
        [HttpGet]
        public IActionResult SetItem(string val)
        {
            //Set
            _provider.Set("demo", val, TimeSpan.FromDays(1));

            return Ok(val);
        }
    }
}