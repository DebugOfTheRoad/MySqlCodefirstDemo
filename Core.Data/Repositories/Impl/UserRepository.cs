using Common.Data;
using Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories.Impl
{
    [Export(typeof(IUserRepository))]
    public partial class UserRepository : EFRepository<User>,IUserRepository
    {
    }
}
