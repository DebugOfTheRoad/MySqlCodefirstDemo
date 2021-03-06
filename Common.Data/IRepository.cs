﻿using Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    public interface IRepository<TEntity> where TEntity : Entity
    {

        #region 属性

 
        IQueryable<TEntity> Entities { get; }

        #endregion

        #region 公共方法

      
        int Insert(TEntity entity, bool isSave = true);

       
        int Insert(IEnumerable<TEntity> entities, bool isSave = true);

         
        int Delete(object id, bool isSave = true);
 
        int Delete(TEntity entity, bool isSave = true);
 
        int Delete(IEnumerable<TEntity> entities, bool isSave = true);

   
        int Delete(Expression<Func<TEntity, bool>> predicate, bool isSave = true);

        
        int Update(TEntity entity, bool isSave = true);

 
        TEntity GetByKey(object key);
        #endregion
    }
}
