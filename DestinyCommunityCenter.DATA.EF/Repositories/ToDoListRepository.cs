using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyCommunityCenter.DATA.EF.Repositories
{
    public class ToDoListRepository : GenericRepository<ToDoList>
    {
        public ToDoListRepository(DbContext db) : base(db) { }
    }
}
