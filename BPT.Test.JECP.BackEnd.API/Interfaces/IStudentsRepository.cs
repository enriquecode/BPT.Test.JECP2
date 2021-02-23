using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPT.Test.JECP.BackEnd.API.Models;
    //using BPT.Test.JECP.BackEnd.DataAccess.Models;

namespace BPT.Test.JECP.BackEnd.API.Interfaces
{
    public interface IStudentsRepository
    {
        IEnumerable<Estudiante> GetAllStudents();
        //string GetAllStudents();
    }
}
