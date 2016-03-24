using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Student.Service;

namespace MyAPP.Controllers
{
    public class StudentController : BaseController
    {
        public IHttpActionResult Post(Student.Model.Student student)
        {
            StudentService service = new StudentService(Db);
            student.Id = Guid.NewGuid().ToString();
            
           
           return Ok(service.Add(student));
        }
    }
}
