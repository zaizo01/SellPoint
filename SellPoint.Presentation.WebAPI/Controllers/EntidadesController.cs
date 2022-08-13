using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellPoint.Business.Interfaces;
using SellPoint.Data.DTOs.Entidades;
using SellPoint.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellPoint.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EntidadesController : ControllerBase
    {
        private readonly IGenericRepository<Entidades> repository;
        private readonly IEntitidadesRepository<Entidades> entityService;
        private readonly IMapper mapper;

        public EntidadesController(IGenericRepository<Entidades> repository, IEntitidadesRepository<Entidades> entityService, IMapper mapper)
        {
            this.repository = repository;
            this.entityService = entityService;
            this.mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> Login(UserCredentialsDTO userCredentialsDTO)
        {
            try
            {
                var entity = mapper.Map<Entidades>(userCredentialsDTO);
                var response = await entityService.Login(entity);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEntityById(int id)
        {
            try
            {
                var entity = await repository.GetById(id);
                if (entity is null) return NotFound("Esta entidad no existe.");
                return Ok(mapper.Map<EntidadesGetDTO>(entity));
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
                return Ok(mapper.Map<List<EntidadesGetDTO>>(entities));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntity(EntidadesPostDTO entidadesPostDTO)
        {
            try
            {
                var entity = mapper.Map<Entidades>(entidadesPostDTO);
                await repository.Create(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEntity(EntidadesPutDTO entidadesPutDTO)
        {
            try
            {
                var entity = mapper.Map<Entidades>(entidadesPutDTO);
                await repository.Update(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
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
