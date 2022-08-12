using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellPoint.Business.Interfaces;
using SellPoint.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellPoint.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadesController : ControllerBase
    {
        private readonly IGenericRepository<Entidades> repository;

        public EntidadesController(IGenericRepository<Entidades> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEntityById(int id)
        {
            try
            {
                var entity = await repository.GetById(id);
                if (entity is null) return NotFound("Esta entidad no existe.");
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEntities()
        {
            try
            {
                var entities = await repository.GetAll();
                return Ok(entities);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntity(Entidades entidades)
        {
            try
            {
                var entity = await repository.Create(entidades);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEntity(Entidades entidades)
        {
            try
            {
                var entity = await repository.Update(entidades);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEntity(int id)
        {
            try
            {
                await repository.Delete(id);
                return Ok("Entidad eliminada.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
