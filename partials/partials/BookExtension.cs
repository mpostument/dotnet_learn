public static class BookExtension
{
    public static string GetDescription(this Book book)
    {
        return $"{book.Title} — {book.Author} ({book.YearPublished})";
    }
}