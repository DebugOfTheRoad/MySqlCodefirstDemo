using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Repositories;
using Core.Model;
using System.ComponentModel.Composition;

namespace Core.Impl
{
    [Export(typeof(IUserContract))]
    internal class UserService : CoreService, IUserContract
    {
        [Import]
        protected IUserRepository UserRespository { get; set; }

        public IQueryable<User> Users
        {
            get { return UserRespository.Entities; }
        }

        public virtual void Insert(User entity)
        {
            UserRespository.Insert(entity);
        }
    }
}
