﻿using Microsoft.EntityFrameworkCore;
using StackOverflowAPI_DAL.Contracts;
using StackOverflowAPI_DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowAPI_DAL.Repository
{
    public abstract class RepositeryBase<T>: IRepositeryBase<T> where T : class
    {
        protected ApplicationDbContext _context;
        public RepositeryBase(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<T> FindAll(bool trackChanges) => 
            trackChanges ?
            _context.Set<T>().AsNoTracking()
           : 
            _context.Set<T>();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            _context.Set<T>().Where(expression).AsNoTracking()
            : _context.Set<T>().Where(expression);
        public void Create(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}
