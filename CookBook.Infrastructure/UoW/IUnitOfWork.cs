namespace CookBook.Infrastructure.UoW
{
    public interface IUnitOfWork
    {
        public int SaveChanges();
    }
}
