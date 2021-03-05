using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CicdApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{

		[HttpGet("upper")]
		public string ToUpper([FromQuery] string value) 
		{
			if (string.IsNullOrEmpty(value))
			{
				return "Provide a query param of value";
			}
			return value.ToUpper();
		}

		[HttpGet("lower")]
		public string ToLower([FromQuery] string value) 
		{
			if (string.IsNullOrEmpty(value))
			{
				return "Provide a query param of value";
			}
			return value.ToLower();
		}


		[HttpGet("health")]
		public string HealthCheck([FromQuery] string value) 
		{
			return "Health is Good";
		}
	}
}
