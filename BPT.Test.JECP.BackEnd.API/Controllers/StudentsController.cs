using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BPT.Test.JECP.BackEnd.API.Interfaces;
using BPT.Test.JECP.BackEnd.API.Models;

//using BPT.Test.JECP.BackEnd.DataAccess.Models;

namespace BPT.Test.JECP.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public IStudentsRepository StudentsRepo
        {
            get; set;
        }


        public StudentsController(IStudentsRepository _repo)
        {
            StudentsRepo = _repo;
        }

        [HttpGet]
        public IEnumerable<Estudiante> GetAllStudents()
            
        {

            return StudentsRepo.GetAllStudents();
            //return "Hola";

            //return new Clientes { IdCliente = 1, NombreCliente = "Juan" };
        }
    }
}
