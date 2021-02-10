using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmanları, diğer katmanları referans almaz !!!
namespace Core.DataAccess
{
    //generic constraint
    //referans tip olabilir
    //IEntity veya ientittyi implemente eden bir nesne olabilir
    //new() :new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        

    }
}
