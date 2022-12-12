using SocialNetwork.Core.Helpers.Result.Abstract;
using static SocialNetwork.Entities.DTOs.PostDTO;

namespace SocialNetwork.Business.Abstract
{
    public interface IPostService
    {
        IResult CreatePost(PostCreateDTO postCreate, Guid userId);
    }
}