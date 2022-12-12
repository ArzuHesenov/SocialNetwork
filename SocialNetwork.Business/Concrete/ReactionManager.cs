using SocialNetwork.Business.Abstract;
using SocialNetwork.Business.Constants;
using SocialNetwork.Core.Helpers.Result.Abstract;
using SocialNetwork.Core.Helpers.Result.Concrete.ErrorResults;
using SocialNetwork.Core.Helpers.Result.Concrete.SuccessResults;
using SocialNetwork.DataAccess.Abstract;

namespace SocialNetwork.Business.Concrete
{
    public class ReactionManager : IReactionService
    {
        private readonly IReactionDal _reactionDal;

        public ReactionManager(IReactionDal reactionDal)
        {
            _reactionDal = reactionDal;
        }

        public IResult LikePost(Guid userId, int postId)
        {
            try
            {
                _reactionDal.LikePost(userId, postId);
                return new SuccessResult(Messages.SuccessfullyLike);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);  
            }
        }
    }
}