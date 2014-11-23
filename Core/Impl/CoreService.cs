using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Data;
using System.ComponentModel.Composition;

namespace Core.Impl
{
    public class CoreService
    {
        [Import]
        protected IWorkBase Work { get; set; }
    }
}
