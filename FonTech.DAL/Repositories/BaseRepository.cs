namespace FonTech.DAL.Repositories;

using Domain.Interfaces.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _dbСontext;
    
    public BaseRepository(ApplicationDbContext dbСontext) => _dbСontext = dbСontext;
    
    public IQueryable<TEntity> GetAll()
    {
        return _dbСontext.Set<TEntity>(); // что будет в Set<TEntity> то и достанется из БД
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        if(entity is null) 
            throw new ArgumentNullException(nameof(entity));
        
        await _dbСontext.AddAsync(entity);
        await _dbСontext.SaveChangesAsync();

        return entity;
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (entity is null) 
            throw new ArgumentNullException("Entity is null");
        
        _dbСontext.Update(entity);
        _dbСontext.SaveChanges();
        
        return Task.FromResult(entity);
    }

    public Task<TEntity> DeleteAsync(TEntity entity)
    {
        if (entity is null) 
            throw new ArgumentNullException(nameof(entity));
        
        _dbСontext.Remove(entity);
        _dbСontext.SaveChanges();
        
        return Task.FromResult(entity);
    }
}