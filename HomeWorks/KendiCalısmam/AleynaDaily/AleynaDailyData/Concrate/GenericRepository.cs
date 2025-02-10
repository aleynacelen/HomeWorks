using System;
using AleynaDailyData.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AleynaDailyData.Concrate;

public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class

{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<TEntity> _dbSet;
    public GenericRepository()
    {
       _context = _context;
         _dbSet = _context.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
}


