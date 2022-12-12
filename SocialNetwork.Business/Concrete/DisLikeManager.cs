using SocialNetwork.Core.Helpers.Result.Abstract;
using SocialNetwork.Business.Abstract;
using SocialNetwork.Business.Constants;
using SocialNetwork.DataAccess.Abstract;
using SocialNetwork.Core.Helpers.Result.Concrete.ErrorResults;
using SocialNetwork.Core.Helpers.Result.Concrete.SuccessResults;
using SocialNetwork.DataAccess.Concrete.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Business.Concrete
{
    public class DisLikeManager : IDisLikeService
    {
        private readonly IDisLikeDal _disLikeDal;

        public DisLikeManager(IDisLikeDal disLikeDal)
        {
            _disLikeDal = disLikeDal;
        }

        public IResult DisLikePost(Guid userId, int postId)
        {
            try
            {
                _disLikeDal.DisLikePost(userId, postId);
                return new SuccessResult(Messages.SuccessfullyDisLike);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
