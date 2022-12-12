using SocialNetwork.Core.Helpers.Result.Abstract;

namespace SocialNetwork.Business.Abstract
{
    public interface IReactionService
    {
        IResult LikePost(Guid userId, int postId);
    }
}