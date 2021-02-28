﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _0_Framework.Domain
{
    public interface IRepository<TKey, T> where T : class 
    {
        T Get(TKey id);
        List<T> GetAll();
        void Create(T entity);
        bool Exists(Expression<Func<T,bool>>expression);
        void SaveChanges();
    }
}
