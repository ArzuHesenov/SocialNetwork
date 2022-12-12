using Microsoft.EntityFrameworkCore;
using SocialNetwork.Core.DataAccess.EntityFramework;
using SocialNetwork.Core.Entities.Concrete;
using SocialNetwork.DataAccess.Abstract;
using SocialNetwork.DataAccess.Concrete.EntityFramwork;
using SocialNetwork.Entities.DTOs;
using System.Security.Cryptography.X509Certificates;
using static SocialNetwork.Entities.DTOs.PostDTO;

namespace SocialNetwork.Core.DataAccess.Concrete
{
    public class UserDal : EfRepositoryBase<User, AppDbContext>, IUserDal
    {
        public IEnumerable<ProfilePostDisLikeDTO> GetUserDisLikePost(Guid userId)
        {
            using AppDbContext context = new();
            List<ProfilePostDisLikeDTO> disLikeDTOs = new();
            var posts=context.Posts.Include(x=>x.DisLikes).Where(x=>x.UserId== userId).ToList();
            foreach (var post in posts) 
            {
                int disLikeCount=post.DisLikes.Where(x=>x.IsDisLike==true).Count();
                ProfilePostDisLikeDTO disLikeDTO = new(post.Id, post.Content, disLikeCount);
                disLikeDTOs.Add(disLikeDTO);
            }
            return disLikeDTOs;
        }

        public IEnumerable<ProfilePostLikeDTO> GetUserProfilePost(Guid userId)
        {
            using AppDbContext context = new();
            List<ProfilePostLikeDTO> result= new();
            var posts = context.Posts.Include(x => x.Reactions).Where(x => x.UserId == userId).ToList();
            foreach (var post in posts)
            {
                int likeCount=post.Reactions.Where(x=>x.IsLike==true).Count();
                ProfilePostLikeDTO postLikeDTO = new(post.Id, post.Content, likeCount);
                result.Add(postLikeDTO);
            }
            return result;
        }
    }
}