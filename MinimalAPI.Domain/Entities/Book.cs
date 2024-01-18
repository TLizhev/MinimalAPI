namespace MinimalAPI.Domain.Entities;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int EditionType { get; set; }
    public decimal Price { get; set; }
    public int Copies { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int AgeRestriction { get; set; }

    public int AuthorId { get; set; }
    public virtual Author? Author { get; set; }
}