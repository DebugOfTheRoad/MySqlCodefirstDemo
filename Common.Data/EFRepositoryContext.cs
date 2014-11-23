using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    [Export(typeof(IWorkBase))]
    internal class EFRepositoryContext : WorkContext
    {
        /// <summary>
        /// 获取 当前使用的数据访问上下文对象
        /// </summary>
        protected override DbContext Context
        {
            get { return EFDbContext; }
        }


        [Import(typeof(DbContext))]
        private EFDbContext EFDbContext { get; set; }
    }
}
