using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tzunami_test.Models;

namespace tzunami_test.DAL
{
    public interface IUsersRepository : IDisposable
    {
        IEnumerable<BaseUser> GetUsers();
        BaseUser GetUserByID(long ID);
        void InsertUser(BaseUser User);
        void DeleteUser(long ID);
        void UpdateUser(BaseUser User);
    }

    public class UsersRepository : IUsersRepository, IDisposable
    {
        private List<BaseUser> context;

        public UsersRepository(List<BaseUser> context)
        {
            this.context = context;
        }

        public IEnumerable<BaseUser> GetUsers()
        {
            return context;
        }

        public BaseUser GetUserByID(long ID)
        {
            return context.Find(x => x.ID.Equals(ID));
        }


        public void DeleteUser(long ID)
        {
            BaseUser entity = context.Find(x => x.ID.Equals(ID));
            context.Remove(entity);
        }

        public void UpdateUser(BaseUser User)
        {
            BaseUser entity = context.Find(x => x.ID.Equals(User.ID));
            entity.EMail = User.EMail;
            entity.FirstName = User.FirstName;
            entity.LastName = User.LastName;
            entity.PhoneNumber = User.PhoneNumber;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Clear();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void InsertUser(BaseUser User)
        {
            if (context == null)
            {
                context = new List<BaseUser>();
                User.ID = 1;
            }
            else
            {
                User.ID = context.Count() + 1;
            }
            context.Add(User);
        }
    }
}