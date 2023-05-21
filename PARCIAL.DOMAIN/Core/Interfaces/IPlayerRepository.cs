using PARCIAL.DOMAIN.Core.Entities;

namespace PARCIAL.DOMAIN.Core.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAll();
        Task<bool> Insert(Player player);
    }
}