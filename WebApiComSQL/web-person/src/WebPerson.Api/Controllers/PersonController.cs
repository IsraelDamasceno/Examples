using Microsoft.AspNetCore.Mvc;
using WebPerson.Interfaces;
using WebPerson.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace WebPerson.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        protected readonly IRepository _repository;

        public PersonController(IRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<ActionResult> LerTodos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                return Ok(await _repository.GetAllAsync());

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetWithId")]
        public async Task<ActionResult> GetWithId(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _repository.GetPersonAsync(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                await _repository.CreatePersonAsync(person);
                return Created(new Uri(Url.Link("GetWithId", new { id = person.BusinessEntityID })), person);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _repository.UpdateAsync(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _repository.DeleteAsync(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }
    }
}
