using System;
using Microsoft.AspNetCore.Mvc;
using Controllers;

namespace HelloWorldAng
{
  [Route("api/[Controller]")]
  public class HelloController : Controller
  {
    Banco b = new Banco();

    [HttpGet]
    public IActionResult Greetings()
    {
      return Ok(b.Resultado());
    }
  }
}
