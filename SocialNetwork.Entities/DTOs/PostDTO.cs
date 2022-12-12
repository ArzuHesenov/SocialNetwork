using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Entities.DTOs
{
    public class PostDTO
    {
        public record PostCreateDTO(string Content);
        public record PostDeleteDTO(int Id);
        public record ProfilePostLikeDTO(int postId,string Content,int Likes);
        public record ProfilePostDisLikeDTO(int postId,string Content,int DisLikes);
    }
}
