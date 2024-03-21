

using Infrastructure.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class Repo<TEntity>(DataContext context) where TEntity : class
{
	private readonly DataContext _context = context;


	public virtual async Task<ResponseResult> CreateOneAsync (TEntity entity)
	{
		try
		{
			_context.Set<TEntity>().Add(entity);
			await _context.SaveChangesAsync();
			return new ResponseResult
			{
				ContentReult = entity,
				Message = "Created succesfully",
				StatusCode = StatusCode.OK

			};
		}
		catch (Exception ex) 
		{
			return ResponseFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponseResult> GetAllAsync()
	{
		try
		{
			IEnumerable<TEntity> result = await _context.Set<TEntity>().ToListAsync();
			return ResponseFactory.Ok(result);
			
		}
		catch (Exception ex)
		{
			return ResponseFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponseResult> GetOneAsync(Expression<Func<TEntity, bool>> predicate)
	{
		try
		{
			var result = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
			if (result == null)
				return ResponseFactory.NotFound();
			return ResponseFactory.Ok(result);

		}
		catch (Exception ex)
		{
			return ResponseFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponseResult> UpdateOneAsync(Expression<Func<TEntity, bool>> predicate, TEntity UpdatedEntity)
	{
		try
		{
			var result = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
			if (result != null)
			{
				_context.Entry(result).CurrentValues.SetValues(UpdatedEntity);
				await _context.SaveChangesAsync();
					return ResponseFactory.Ok(result);
			}
				return ResponseFactory.NotFound();
			

		}
		catch (Exception ex)
		{
			return ResponseFactory.Error(ex.Message);
		}
	}
	public virtual async Task<ResponseResult> DeleteOneAsync(Expression<Func<TEntity, bool>> predicate)
	{
		try
		{
			var result = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
			if (result != null)
			{
				_context.Set<TEntity>().Remove(result);
				await _context.SaveChangesAsync();
				return ResponseFactory.Ok(" Successfully Deleted");
			}
			return ResponseFactory.NotFound();


		}
		catch (Exception ex)
		{
			return ResponseFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponseResult> AllreadyExistsAsync(Expression<Func<TEntity, bool>> predicate)
	{
		try
		{
			var result = await _context.Set<TEntity>().AnyAsync(predicate);
			if (result)
			
				
				return ResponseFactory.Exists();
			
			return ResponseFactory.NotFound();


		}
		catch (Exception ex)
		{
			return ResponseFactory.Error(ex.Message);
		}
	}
}
