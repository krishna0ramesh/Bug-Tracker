public class Bug
{
    public int BugId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } // Example: "Open", "In Progress", "Closed"
    public DateTime CreatedDate { get; set; }
    public int ProjectId { get; set; } // Foreign key to Project
    public Project Project { get; set; } // Navigation property to Project

    // Constructor
    public Bug()
    {
        CreatedDate = DateTime.Now;
    }
}
