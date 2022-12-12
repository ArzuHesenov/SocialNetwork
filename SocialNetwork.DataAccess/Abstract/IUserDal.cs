using SocialNetwork.Core.DataAccess;
using SocialNetwork.Core.Entities.Concrete;
using static SocialNetwork.Entities.DTOs.PostDTO;

namespace SocialNetwork.DataAccess.Abstract
{
    public interface IUserDal: IRepositoryBase<User>
    {
        IEnumerable<ProfilePostLikeDTO> GetUserProfilePost(Guid userId);
        IEnumerable<ProfilePostDisLikeDTO> GetUserDisLikePost(Guid userId);
    }
}