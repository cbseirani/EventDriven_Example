namespace Repositories.MongoModels;

public class Content
{
    public Guid Id { get; set; } // Unique identifier
    public string Description { get; set; } // Description of the beat
    public DateTimeOffset Timestamp { get; set; } // Timestamp of when the beat was created or modified
}