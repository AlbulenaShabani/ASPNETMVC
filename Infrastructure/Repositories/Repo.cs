

using Infrastructure.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class Repo<TEntity>(DataContext context) where TEntity : class
{
	private readonly DataContext _context = context;


	public virtual async Task<ResponsResult> CreateOneAsync (TEntity entity)
	{
		try
		{
			_context.Set<TEntity>().Add(entity);
			await _context.SaveChangesAsync();
			return new ResponsResult
			{
				ContentReult = entity,
				Message = "Created succesfully",
				StatusCode = StatusCode.OK

			};
		}
		catch (Exception ex) 
		{
			return ResponsFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponsResult> GetAllAsync()
	{
		try
		{
			IEnumerable<TEntity> result = await _context.Set<TEntity>().ToListAsync();
			return ResponsFactory.Ok(result);
			
		}
		catch (Exception ex)
		{
			return ResponsFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponsResult> GetOneAsync(Expression<Func<TEntity, bool>> predicate)
	{
		try
		{
			var result = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
			if (result == null)
				return ResponsFactory.NotFound();
			return ResponsFactory.Ok(result);

		}
		catch (Exception ex)
		{
			return ResponsFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponsResult> UpdateOneAsync(Expression<Func<TEntity, bool>> predicate, TEntity UpdatedEntity)
	{
		try
		{
			var result = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
			if (result != null)
			{
				_context.Entry(result).CurrentValues.SetValues(UpdatedEntity);
				await _context.SaveChangesAsync();
					return ResponsFactory.Ok(result);
			}
				return ResponsFactory.NotFound();
			

		}
		catch (Exception ex)
		{
			return ResponsFactory.Error(ex.Message);
		}
	}
	public virtual async Task<ResponsResult> DeleteOneAsync(Expression<Func<TEntity, bool>> predicate)
	{
		try
		{
			var result = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
			if (result != null)
			{
				_context.Set<TEntity>().Remove(result);
				await _context.SaveChangesAsync();
				return ResponsFactory.Ok(" Successfully Deleted");
			}
			return ResponsFactory.NotFound();


		}
		catch (Exception ex)
		{
			return ResponsFactory.Error(ex.Message);
		}
	}

	public virtual async Task<ResponsResult> AllreadyExistsAsync(Expression<Func<TEntity, bool>> predicate)
	{
		try
		{
			var result = await _context.Set<TEntity>().AnyAsync(predicate);
			if (result)
			
				
				return ResponsFactory.Exists();
			
			return ResponsFactory.NotFound();


		}
		catch (Exception ex)
		{
			return ResponsFactory.Error(ex.Message);
		}
	}
}
