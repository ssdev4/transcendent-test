using System;
using TestProject.Models;

namespace TestProject.Repository.Abstraction
{
	public interface INumberService
	{
        Task<List<NumberEntry>> GetAllNumbersAsync();
        Task AddNumberEntryAsync(NumberEntry numberEntry);
    }
}

