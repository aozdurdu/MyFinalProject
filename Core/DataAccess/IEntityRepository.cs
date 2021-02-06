using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //where: generic constraint. We'll put constraints 
    //class: referans type
    //IEntity: it might be IEntity or object which impelement IEntity. IEntity will be generic.
    //new: it can be new'ed (which only db entities like Category, Product or Customer but not IEntity)
    
    //For list and a function in list, we should use Expression<...> and Func<>. Expression<Func<list item, function>>

    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
