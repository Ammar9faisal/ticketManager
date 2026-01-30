public class Ticket
{
    public Ticket(string title, string description, TicketPriority priority) //ticket class takes title, description as parameters
    {

        Title = title;
        Description = description;
        Priority = priority;
        Status = TicketStatus.Open;   //default status is Open
        CreatedAt = DateTime.Now;
        Id = Guid.NewGuid();
    }

// Getters and Setters for Ticket class
    public Guid Id { get; set; }
    public string Title { get; set;}

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public TicketStatus Status { get; set; }

    public TicketPriority Priority { get; set; }
}

public enum TicketStatus  //created Enum for Ticket Status
{
    Open,
    InProgress,
    Resolved,
    Closed
}

public enum TicketPriority //created Enum for Ticket Priority
{ 
    Low,
    Medium,
    High,
    Critical
}