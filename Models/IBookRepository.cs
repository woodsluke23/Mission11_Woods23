namespace AmazonWoods23.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
