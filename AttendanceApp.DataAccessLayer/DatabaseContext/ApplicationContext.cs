using Microsoft.EntityFrameworkCore;
using AttendanceApp.DataAccessLayer.Models;

namespace AttendanceApp.DataAccessLayer.DatabaseContext
{
    public class ApplicationContext : DbContext
    {
        protected ApplicationContext(DbContextOptions options) : base(options)
        { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        #region DbSets

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<StudentAttendance> StudentAttendances { get; set; }

        #endregion

    }
}
