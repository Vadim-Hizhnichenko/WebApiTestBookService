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
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorsService;

        public AuthorController(IAuthorService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddBook([FromBody] AuthorViewModel authorVm)
        {
            _authorsService.AddAuthor(authorVm);
            return Ok();
        }

        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorWithBooks(int id)
        {
            var autorWithBooks = _authorsService.GetAuthorWithBooks(id);
            return Ok(autorWithBooks);

        }


    }
}
