using LawSchool.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawSchool.Service.Contracts
{
    public interface Istudent
    {
        Task<IEnumerable<Student>> GetAll();

        Task<Student> GetById(int Id);

        Task<bool> IfIdExist(int Id);

        Task<Student> Add(Student studentInput);

        Task Update(Student studentInput);
    }
}