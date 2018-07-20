using DestinyCommunityCenter.DATA.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyCommunityCenter.DATA.EF
{
    public class UnitOfWork
    {
        public DestinyCommCtrEntities context = new DestinyCommCtrEntities();


        private ToDoRepository _todoRepository;
        public ToDoRepository ToDoRepository
        {
            get
            {
                if (this._todoRepository == null)
                {
                    this._todoRepository = new ToDoRepository(context);
                }
                return _todoRepository;
            }
        }

        private ToDoListRepository _todolistRepository;
        public ToDoListRepository ToDoListRepository
        {
            get
            {
                if (this._todolistRepository == null)
                {
                    this._todolistRepository = new ToDoListRepository(context);
                }
                return _todolistRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
