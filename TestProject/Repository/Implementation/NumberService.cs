using System;
using Microsoft.EntityFrameworkCore;
using TestProject.Data;
using TestProject.Models;
using TestProject.Repository.Abstraction;

namespace TestProject.Repository.Implementation
{
    public class NumberService : INumberService
    {
        private readonly ApplicationDbContext _context;

        public NumberService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<NumberEntry>> GetAllNumbersAsync()
        {
            return await _context.NumberEntries.ToListAsync();
        }

        public async Task AddNumberEntryAsync(NumberEntry numberEntry)
        {
            numberEntry.SquaredNumber = (int)Math.Pow(numberEntry.OriginalNumber * 2, 2);
            _context.NumberEntries.Add(numberEntry);
            await _context.SaveChangesAsync();
        }
    }
}

