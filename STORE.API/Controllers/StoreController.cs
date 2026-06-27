using Microsoft.AspNetCore.Mvc;
using Store.Application.service;
using Store.Domain.Entities;

namespace Store.API.Controllers;

[ApiController]
[Route("api/store")]
public class StoreController(IStoreService storeService): ControllerBase
{

    private readonly IStoreService _storeService = storeService;

    [HttpGet]
    public async Task<IActionResult> GetAllStores()
    {
        return  Ok(await _storeService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        StoreModel store = await _storeService.GetByIdAsync(id);
        if (store is null) return NotFound();
        return Ok(store);
    }
}
