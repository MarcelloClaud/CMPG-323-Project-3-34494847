﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    //All the generic method definitions are defined as follows to be used in all the controllers
    public interface IGenericRepository<T> where T : class
    {
        T GetById(Guid? id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        //Custom code that were not provided:
        //Refer to GenericRepository for more commentary

        bool CheckID(Guid? id);
        bool CheckClass(T t);
        T CheckDetails(Guid? id);
        void Update(T entity);
        void Save();     
        void Create(T t);
        bool Edit(Guid id, T t);
        void DeleteConfirmed(T t);
    }
}
