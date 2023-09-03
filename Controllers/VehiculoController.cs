using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TareaVehiculo.Entities;

namespace TareaVehiculo.Controllers
{
    [ApiController]
    [Route("api/vehiculos")]
    public class VehiculoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Vehiculo>> Get()
        {
            return new List<Vehiculo>()
            {
                new Vehiculo() {Id= 1, Marca="Renault", Modelo= "Kwid", Color="Cobre", Kilometraje= 60000},
                new Vehiculo() {Id= 2, Marca="Volkswagen", Modelo= "Suran", Color="Negro", Kilometraje= 65000}
            };

        }
    }
}
