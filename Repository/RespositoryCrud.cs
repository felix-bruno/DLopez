using Azure.Core;
using CommonModels;
using DBTramiteDocumentarioModels;
using IRepository;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RespositoryCrud<TEntity> where TEntity : class
    {
        #region Inicializar Varibles con Constructor
        internal _dbzapaterilopezContext db;
        internal DbSet<TEntity> dbSet;
        public RespositoryCrud()
        {
            db = new();
            dbSet = db.Set<TEntity>();
        }
        #endregion Inicializar Varibles con Constructor
        #region Crud Generico
        public TEntity Create(TEntity entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> CreateMultiple(List<TEntity> lista)
        {
            dbSet.AddRange(lista);
            db.SaveChanges();
            return lista;
        }

        public int Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            dbSet.Remove(entity);
            return db.SaveChanges();
        }

        public int DeleteMultiple(List<TEntity> lista)
        {
            dbSet.RemoveRange(lista);
            return db.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<TEntity> GetAll()
        {
            IQueryable<TEntity> query = dbSet;
            return query.ToList();
        }

        public TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public TEntity Update(TEntity entity)
        {
            dbSet.Update(entity); 
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> UpdateMultiple(List<TEntity> lista)
        {
            dbSet.UpdateRange(lista);
            db.SaveChanges();
            return lista;
        }
        #endregion Crud Generico
    }
}