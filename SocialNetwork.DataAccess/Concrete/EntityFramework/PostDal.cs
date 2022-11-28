using SocialNetwork.Core.DataAccess.EntityFramework;
using SocialNetwork.DataAccess.Abstract;
using SocialNetwork.Entities.Concrete;

namespace SocialNetwork.DataAccess.Concrete.EntityFramwork
{
    public class PostDal : EfRepositoryBase<Post , AppDbContext>, IPostDal
    {
        
    }
}