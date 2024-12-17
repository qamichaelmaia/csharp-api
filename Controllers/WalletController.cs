using Microsoft.AspNetCore.Mvc;
using WalletApi.Data;
using WalletApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WalletApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WalletController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateWallet([FromBody] Wallet wallet)
        {
            if (wallet == null)
                return BadRequest();

            _context.Wallets.Add(wallet);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateWallet), new { id = wallet.ID }, wallet);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetWalletsByUser(int userId)
        {
            var wallets = await _context.Wallets.Where(w => w.UserID == userId).ToListAsync();
            if (wallets == null || wallets.Count == 0)
                return NotFound();

            return Ok(wallets);
        }
    }
}
