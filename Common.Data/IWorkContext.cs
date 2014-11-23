using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Tools;
using System.Data.Entity;

namespace Common.Data
{
    public interface IWorkContext : IWorkBase , IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
        void RegisterNew<TEntity>(TEntity entity) where TEntity : Entity;
        void RegisterNew<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity;
        void RegisterModified<TEntity>(TEntity entity) where TEntity : Entity;
        void RegisterDeleted<TEntity>(TEntity entity) where TEntity : Entity;
        void RegisterDeleted<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity;
    
    }
}
