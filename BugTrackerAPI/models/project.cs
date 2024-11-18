using System.Collections.Generic;

public class Project
{
    public int ProjectId { get; set; }
    public required string ProjectName { get; set; }
    public required string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ICollection<Bug> Bugs { get; set; } // Relationship to Bugs

    // Constructor
    public Project()
    {
        Bugs = new List<Bug>();
    }
}
