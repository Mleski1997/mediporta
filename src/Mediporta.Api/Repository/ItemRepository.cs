﻿using Mediporta.Api.Data;
using Mediporta.Api.Models;

namespace Mediporta.Api.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _context;

        public ItemRepository(DataContext context)
        {
            _context = context;
        }

      
        public async Task AddAsync(List<Item> items)
        {

            await _context.AddRangeAsync(items);
            await _context.SaveChangesAsync();
        }
    }
}
