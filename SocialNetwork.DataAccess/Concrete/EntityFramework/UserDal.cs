using SocialNetwork.Core.DataAccess.EntityFramework;
using SocialNetwork.Core.Entities.Concrete;
using SocialNetwork.DataAccess.Abstract;
using SocialNetwork.DataAccess.Concrete.EntityFramwork;

namespace SocialNetwork.Core.DataAccess.Concrete
{
    public class UserDal: EfRepositoryBase<User, AppDbContext>, IUserDal
    {
        
    }
}