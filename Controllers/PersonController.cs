using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyServer.BL.Services;
using MyServer.BL.Interfaces;
using MyServer.DL;
using MyServer.Models;
using System.Threading.Tasks;
using RabbitMQ.Client;


namespace MyServer.Controllers
{
    [ApiController]
    [Route("controller")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IRabbitMqService _rabbitMq;

        public PersonController(ILogger<PersonController> logger, IRabbitMqService rabbitMq)
        {
            _logger = logger;
            _rabbitMq = rabbitMq;
        }

        [HttpPost]
        public async Task<IActionResult> SendPerson([FromBody] Person p)
        {
            await _rabbitMq.PublishPersonAsync(p);

            return Ok();
        }

        //[HttpPost("InsertInMongo")]
        //public async Task<IActionResult> InsertPerson([FromBody] Person p)
        //{
        //    await _personRepository
        //}

    }
}
