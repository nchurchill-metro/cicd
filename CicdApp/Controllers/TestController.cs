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

		[HttpGet]
		public string GetStuff([FromQuery] string value) 
		{
			if (string.IsNullOrEmpty(value))
			{
				return "Provide a query param of value";
			}
			return value.ToUpper();
		}
	}
}
