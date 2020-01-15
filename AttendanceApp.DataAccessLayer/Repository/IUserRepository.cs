using AttendanceApp.DataAccessLayer.DatabaseContext;
using AttendanceApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceApp.DataAccessLayer.Repository
{
    public class IUserRepository : BaseRepository<User>, IRepository<User>
    {
        public IUserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
