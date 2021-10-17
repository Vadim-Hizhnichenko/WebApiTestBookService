using BusinessLayer.Interfaces;
using BusinessLayer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddBook([FromBody] PublisherViewModel publisherVm)
        {
            _publisherService.AddPublisher(publisherVm);
            return Ok();
        }

        [HttpGet("get-publiher-books-with-authors/{id}")]
        public IActionResult GetPublisherData(int id)
        {
            var publisherData = _publisherService.GetPublisherData(id);
            return Ok(publisherData);
        }

        [HttpGet("get-publisher-by-id/{id}")]
        public IActionResult GetPublisherById(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            if(publisher != null)
            {
                return Ok(publisher);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpDelete("delete-publisher-by-id/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            try
            {
                _publisherService.DeletePublisherById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
