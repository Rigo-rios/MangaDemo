using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Models.Models.Mangas;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace mangahut.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MangaController : ControllerBase
    {
        private readonly IMangaService _mangaService;

        public MangaController(IMangaService mangaService)
        {
            _mangaService = mangaService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var selectedManga = await _mangaService.GetManga(id);
            if(selectedManga is null) return NotFound();
            return Ok(selectedManga);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MangaCreate model)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            
                        return (await _mangaService.AddManga(model)) ? Ok("Success") : BadRequest("Fail.");
        }
    }
}