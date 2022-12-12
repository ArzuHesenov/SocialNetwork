using SocialNetwork.Core.DataAccess.EntityFramework;
using SocialNetwork.DataAccess.Abstract;
using SocialNetwork.Entities.Concrete;

namespace SocialNetwork.DataAccess.Concrete.EntityFramwork
{
    public class ReactionDal : EfRepositoryBase<Reaction, AppDbContext>, IReactionDal
    {
        public void LikePost(Guid userId, int postId)
        {
            using AppDbContext context = new();
            var postLike =context.Reactions.FirstOrDefault(x=>x.UserId==userId && x.PostId==postId);
            if(postLike ==null) 
            {
                context.Reactions.Add(new Reaction
                {
                    UserId = userId,
                    PostId = postId,
                    IsLike= true
                });
            }
            else
            {
                context.Reactions.Remove(postLike);
            }
            context.SaveChanges();
        }
    }
}