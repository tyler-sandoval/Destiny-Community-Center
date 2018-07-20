using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyCommunityCenter.DATA.EF.Repositories
{
    public class ToDoRepository : GenericRepository<ToDo>
    {
        public ToDoRepository(DbContext db) : base(db) { }
    }
}
