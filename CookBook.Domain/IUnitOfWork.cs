namespace CookBook.Domain
{
    public interface IUnitOfWork
    {
        public int SaveChanges();
    }
}
