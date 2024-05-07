using System.ComponentModel.DataAnnotations;

Console.Write("Hello World");

public class Book
{
    [Length(5, 50)] 
    public string? Name { get; set; }

    [Base64String] 
    public string Cover { get; set; }

    [Range(1, 100, MinimumIsExclusive = true, MaximumIsExclusive = false)]
    public double Price { get; set; }

    [AllowedValues("Fiction", "Non-Fiction")]
    [DeniedValues("Horror")]
    public string? Category { get; set; }
}