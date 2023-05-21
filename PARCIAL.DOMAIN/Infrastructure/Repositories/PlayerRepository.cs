using Microsoft.EntityFrameworkCore;
using PARCIAL.DOMAIN.Core.Entities;
using PARCIAL.DOMAIN.Core.Interfaces;
using PARCIAL.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL.DOMAIN.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly Parcial202321100566Context _dbContext;

        public PlayerRepository(Parcial202321100566Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Insert(Player player)
        {
            await _dbContext.Player.AddAsync(player);
            var rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<IEnumerable<Player>> GetAll()
        {
            var result = await _dbContext.Player.ToListAsync();
            return result;
        }


    }
}
