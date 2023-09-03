using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TareaVehiculo.Entities;

namespace TareaVehiculo.Controllers
{
    [ApiController]
    [Route("api/vehiculos_dto")]
    public class VehiculoDtoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<VehiculoDto>> Get()
        {
            return new List<VehiculoDto>()
            {
                new VehiculoDto() {Id= 1, Marca="Chevrolet", Modelo= "Cruze", Color="Plata"},
                new VehiculoDto() {Id= 2, Marca="Volkswagen", Modelo= "T-cross", Color="Blanco Puro"}
            };

        }
    }
}
