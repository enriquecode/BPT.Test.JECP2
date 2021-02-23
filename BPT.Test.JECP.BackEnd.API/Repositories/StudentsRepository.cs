using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPT.Test.JECP.BackEnd.API.Interfaces;
using BPT.Test.JECP.BackEnd.API.DataAccess;
using BPT.Test.JECP.BackEnd.API.Models;
//using BPT.Test.JECP.BackEnd.DataAccess.Models;



namespace BPT.Test.JECP.BackEnd.API.Repositories
{
    public class StudentsRepository : IStudentsRepository
     {
        //private readonly string _connectionString;
        // private readonly EscuelaEntities _context;

        private readonly SQLServerContext _context;


        static List<Estudiante> listaEstudiantes = new List<Estudiante>();

        public StudentsRepository(SQLServerContext context)
        {
            _context = context;
        }

        public IEnumerable<Estudiante> GetAllStudents()        
        {
            return _context.Estudiantes.ToList();

            //listaEstudiantes.Add(new Estudiantes { Id = 1, Nombre = "Juan" });
            //return listaEstudiantes;
            //return "Hola";
        }
    }
}
