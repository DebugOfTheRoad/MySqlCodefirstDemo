using Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Core.Model
{
    public class User : Entity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }

        public string Salt { get; set; }
    }
}
