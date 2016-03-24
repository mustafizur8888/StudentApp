using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Model;

namespace Student.Repository
{
    public class StudentRepository : BaseRepository
    {
        public StudentRepository(BusinessDbContext db)
            : base(db)
        {
        }

        public bool CheckMail(string email)
        {
            return Db.Students.Any(x => x.Email == email);
        }

        public string Add(Model.Student student)
        {
            Model.Student added = Db.Students.Add(student);
            string msg = string.Empty;
            try
            {
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                
            }
            msg = added.Id;

            return msg;
        }
    }
}
