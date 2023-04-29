using TicketController.Shared.Entities;

namespace TicketController.API.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await TicketAsync();
        }
        private async Task TicketAsync()
        {
            if (!_context.Ticket.Any())
            {
                for (int i = 0; i < 49999; i++)
                {
                    _context.Ticket.Add(new Ticket { UseDate = null, WasUsed = false, Entrance = null });
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}


