using SocialNetwork.Core.DataAccess;
using SocialNetwork.Entities.Concrete;

namespace SocialNetwork.DataAccess.Abstract
{
    public interface IReactionDal : IRepositoryBase<Reaction>
    {
        void LikePost(Guid userId, int postId);
    }
}