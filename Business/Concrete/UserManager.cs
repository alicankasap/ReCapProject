using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length > 2 && user.LastName.Length > 2)
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            }
            return new ErrorResult(Messages.UserCouldntAdded);
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetByMail(string name)
        {
            return new SuccessDataResult<User>(_userDal.GetByMail(name));
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
