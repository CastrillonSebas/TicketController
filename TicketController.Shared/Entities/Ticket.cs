namespace TicketController.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public DateTime? UseDate { get; set; }
        public bool WasUsed { get; set; }
        public string? Entrance { get; set; }

    }
}
