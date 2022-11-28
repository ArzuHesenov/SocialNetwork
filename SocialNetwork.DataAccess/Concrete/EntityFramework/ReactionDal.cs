using SocialNetwork.Core.DataAccess.EntityFramework;
using SocialNetwork.DataAccess.Abstract;
using SocialNetwork.Entities.Concrete;

namespace SocialNetwork.DataAccess.Concrete.EntityFramwork
{
    public class ReactionDal : EfRepositoryBase<Reaction, AppDbContext>, IReactionDal
    {
        
    }
}