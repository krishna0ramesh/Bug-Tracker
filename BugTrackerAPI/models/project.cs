using System.Collections.Generic;

public class Project
{
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ICollection<Bug> Bugs { get; set; } // Relationship to Bugs

    // Constructor
    public Project()
    {
        Bugs = new List<Bug>();
    }
}
