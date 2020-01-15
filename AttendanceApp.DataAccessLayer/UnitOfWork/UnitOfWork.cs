using AttendanceApp.DataAccessLayer.DatabaseContext;
using AttendanceApp.DataAccessLayer.Repository;

namespace AttendanceApp.DataAccessLayer.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationContext _dbContext;
        private BaseRepository<Customer> _customers;
        private BaseRepository<Order> _orders;

        public UnitOfWork(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public I OfferSets => new OfferSetRepository(_subExContext, _subExContextReadOnly);


        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
