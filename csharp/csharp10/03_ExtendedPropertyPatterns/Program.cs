var book = new Book("1234", new Author("Steven King"));

var isFromStevenKing = book is { Author.Name: "Steven King" };

string bookDescription = book switch
{
    { ISBN: "1234" } or { ISBN: "4321" } => "Book has ISBN 1234 oder 4321",
    { Author.Name: "Steven King" } => "Book is from Steven King",
    _ => "No idea"
};

public record Book(string ISBN, Author Author);
public record Author(string Name);