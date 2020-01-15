using AttendanceApp.DataAccessLayer.Repository;
using AttendanceApp.DataAccessLayer.Models;

namespace AttendanceApp.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Location> Locations { get; }
        IRepository<Session> Sessions { get; }
        IRepository<Student> Students { get; }

        void Commit();
    }

}
