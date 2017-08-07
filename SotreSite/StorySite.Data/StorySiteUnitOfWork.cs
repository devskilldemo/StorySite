using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class StorySiteUnitOfWork : IDisposable, IStorySiteUnitOfWork
    {
        private StorySiteContext context;

        public StorySiteUnitOfWork(StorySiteContext context)
        {
            this.context = context;
            this.StoryRepository = new StoryRepository(context);
            this.CommentRepository = new CommentRepository(context);
            this.UserRepository = new UserRepository(context);
            this.DeveloperRepository = new DeveloperRepository(context);
        }

        public IStoryRepository StoryRepository { get; private set; }
        public ICommentRepository CommentRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public IDeveloperRepository DeveloperRepository { get; private set; }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
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

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
