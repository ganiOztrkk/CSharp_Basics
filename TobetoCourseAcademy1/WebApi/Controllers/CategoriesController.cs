﻿using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _categoryService.GetListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]Category category)
        {
            await _categoryService.AddAsync(category);
            return Ok();
        }
    }
}
