using Autofac;
using SocialNetwork.Business.Abstract;
using SocialNetwork.Business.Concrete;
using SocialNetwork.Core.DataAccess.Concrete;
using SocialNetwork.DataAccess.Abstract;
using SocialNetwork.DataAccess.Concrete.EntityFramework;
using SocialNetwork.DataAccess.Concrete.EntityFramwork;

namespace SocialNetwork.Business.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<UserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<PostDal>().As<IPostDal>();
            builder.RegisterType<PostManager>().As<IPostService>();

            builder.RegisterType<ReactionDal>().As<IReactionDal>();
            builder.RegisterType<ReactionManager>().As<IReactionService>();

            builder.RegisterType<DisLikeDal>().As<IDisLikeDal>();
            builder.RegisterType<DisLikeManager>().As<IDisLikeService>();
        }
    }
}