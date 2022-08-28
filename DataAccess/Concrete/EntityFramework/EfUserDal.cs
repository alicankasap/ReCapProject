using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public User GetByMail(string mail)
        {

            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<User>().SingleOrDefault(x => x.Email.Contains(mail));
            }
        }
    }
}
