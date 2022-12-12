using SocialNetwork.Core.Helpers.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Business.Abstract
{
    public interface IDisLikeService
    {
        IResult DisLikePost(Guid userId, int postId);
    }
}
