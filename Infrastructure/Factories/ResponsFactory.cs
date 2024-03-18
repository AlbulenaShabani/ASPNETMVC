
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class ResponsFactory
{
	public static ResponsResult Ok()
	{
		return new ResponsResult
		{
			Message = "Succeeded",
			StatusCode = StatusCode.OK
		};
	}
	public static ResponsResult Ok(string? message = null)
	{
		return new ResponsResult
		{
			Message = "Succeeded",
			StatusCode = StatusCode.OK
		};
	}
	public static ResponsResult Ok(object obj, string? message = null)
	{
		return new ResponsResult
		{
			ContentReult = obj,
			Message = "Succeeded",
			StatusCode = StatusCode.OK
		};
	}
	public static ResponsResult Error( string? message = null)
	{
		return new ResponsResult
		{
			Message = message ?? "Failed",
			StatusCode = StatusCode.ERROR
		};
	}

	public static ResponsResult NotFound( string? message = null)
	{
		return new ResponsResult
		{
			Message = message ?? "Not Found",
			StatusCode = StatusCode.NOT_FOUND
		};
	}

	public static ResponsResult Exists ( string? message = null)
	{
		return new ResponsResult
		{
			Message = message ?? "Already Exists",
			StatusCode = StatusCode.EXISTS
		};
	}
}
