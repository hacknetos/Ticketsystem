using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace tiketsysstem.Data
{
    public class TiketService
    {
        private readonly ApplicationDbContext _context;
        public TiketService(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Tiket>> GetAlltikets(){return await _context.Tikets.ToListAsync();}
        public async Task<bool> Insertiket(Tiket tiket)
        {
            await _context.Tikets.AddAsync(tiket);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delitetiket(Tiket tiket)
        {
             _context.Tikets.Remove(tiket);
            await _context.SaveChangesAsync();
            return true; 
        }

        public async Task<bool> Updatetiket(Tiket tiket)
        {
            _context.Tikets.Update(tiket);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Tiket> Getonetikets(int id)
        {
            return await _context.Tikets.SingleOrDefaultAsync(p => p.ticketid == id);
        }

    }
}
