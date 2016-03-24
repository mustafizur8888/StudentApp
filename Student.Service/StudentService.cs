using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Model;
using Student.Repository;

namespace Student.Service
{
    public class StudentService : BaseService
    {
        StudentRepository repository;

        public StudentService(BusinessDbContext db)
            : base(db)
        {
            repository = new StudentRepository(DbContext);
        }

        public string Add(Model.Student student)
        {
            bool exists = repository.CheckMail(student.Email);
            if (exists)
            {
                return "Use Another Email";
            }
            else
            {
                return repository.Add(student);
            }


        }

        private bool CheckMail(Model.Student student)
        {
            return repository.CheckMail(student.Email);
        }

    }
}
