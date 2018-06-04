using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Repostories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;  //Veritabanı
        private readonly DbSet<T> _dbSet;  //Tablo
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public IList<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IList <T> GetAll(Expression <Func<T,bool>> filter=null,Func<IQueryable <T>,IOrderedQueryable <T>> orderBy=null)
        {
            IQueryable<T> sorgu = _dbSet;
            if (filter != null)
                sorgu = sorgu.Where(filter);
            if (orderBy != null)
                sorgu = orderBy(sorgu);
            return sorgu.ToList();
        }
        public T Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> sorgu = _dbSet;
            if (filter != null)
                sorgu = sorgu.Where(filter);
            if (orderBy != null)
                sorgu = orderBy(sorgu);
            return sorgu.FirstOrDefault();
        } 
        public T Get(int itemID)
        {
            return _dbSet.Find(itemID);
        }
        public bool Add(T item)
        {
            _dbSet.Add(item);
            try
            {
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
                
            }
            return false;
        }
        public void Delete(int itemID)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public T Get(string itemName)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
