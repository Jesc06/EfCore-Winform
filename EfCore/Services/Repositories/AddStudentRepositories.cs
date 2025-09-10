using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore.Services.Database;
using EfCore.DTO;
using EfCore.Model;

namespace EfCore.Services.Repositories
{
    public class AddStudentRepositories
    {
        private readonly ApplicationDbContext _context;
        public AddStudentRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddStudent(addStudentDTO  addstudent)
        {
            var students = new Students
            {
                name = addstudent.name,
                middlename = addstudent.middlename,
                lastname = addstudent.lastname
            };
            _context.Students.Add(students);
            _context.SaveChanges();
        }



    }
}
