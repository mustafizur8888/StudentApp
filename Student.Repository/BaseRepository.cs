using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Model;

namespace Student.Repository
{
    public class BaseRepository
    {
        public BusinessDbContext Db { get; set; }

        protected BaseRepository(BusinessDbContext db)
        {
            this.Db = db;
        }
    }
}
