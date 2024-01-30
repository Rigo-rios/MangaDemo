using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Data.Entities;
using MangaHut.Models.Models.Stores;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace mangahut.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Storecontroller : ControllerBase
    {
        private readonly IStoreService _storeService;

        public Storecontroller(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStores()
        {
            return Ok(await _storeService.GetStores());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetStores(int id)
        {

            var store = await _storeService.GetStore(id);
            if (store is null) return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> PostStore(StoreCreate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _storeService.AddStore(model))
            {
                return Ok("Store was created");
            }
            return BadRequest("Store failed to post");
        }

        [HttpPost]
        [Route("/store_location")]
        public async Task<IActionResult> PostStore(Store_Location_Create model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _storeService.AddStore_Location(model))
            {
                return Ok("Store was created");
            }
            return BadRequest("Store failed to post");
        }



    }
}