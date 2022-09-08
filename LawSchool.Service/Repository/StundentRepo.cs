using LawSchool.Data;
using LawSchool.Data.Data.Entities;
using LawSchool.Service.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawSchool.Service.Repository
{
    public class StundentRepo : Istudent
    {
        private readonly ApplicationDbContext _dbContext;

        public StundentRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Student> Add(Student studentInput)
        {
            await _dbContext.Students.AddAsync(studentInput);
            await _dbContext.SaveChangesAsync();
            return studentInput;
        }


        public async Task<IEnumerable<Student>> GetAll()
        {
            var result = await _dbContext.Students.ToListAsync();
            return result;
        }


        public async Task<Student> GetById(int id)
        {
            var result = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }


        public async Task<bool> IfIdExist(int Id)
        {
            var result = await _dbContext.Students.AnyAsync(x => x.Id == Id);
            return result;
        }
        

        public async Task Update(Student studentInput)
        {
            _dbContext.Update(studentInput);
            await _dbContext.SaveChangesAsync();
        }
    }
}