using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore.Services.Repositories;
using EfCore.Model;
using EfCore.DTO;

namespace EfCore.Controller
{
    public class addStudentController
    {
        private readonly AddStudentRepositories _repository;
        public addStudentController(AddStudentRepositories repository)
        {
            _repository = repository;
        }

        public void AddStudent(addStudentDTO add)
        {
            _repository.AddStudent(add);
        }


    }
}
