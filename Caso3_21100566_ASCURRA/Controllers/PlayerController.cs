using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PARCIAL.DOMAIN.Core.Entities;
using PARCIAL.DOMAIN.Core.Interfaces;

namespace Caso3_21100566_ASCURRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _playerRepository.GetAll();
            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] Player player)
        {
            var result = await _playerRepository.Insert(player);
            if (!result)
                return BadRequest(result);
            return Ok(result);
        }


    }
}
