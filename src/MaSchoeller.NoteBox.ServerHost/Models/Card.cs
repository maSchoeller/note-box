namespace MaSchoeller.NoteBox.ServerHost.Models;

public class Card
{
    public long Id { get; set; }

    public required string Title { get; set; }

    public string? Descirption { get; set; }

    public DateTime CreationTime { get; set; }

    public long? ParentId { get; set; }

    public Card? Parent { get; set; }

    public IList<Source> Sources { get; set; } = [];

}
