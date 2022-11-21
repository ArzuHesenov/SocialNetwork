using Autofac;
using SocialNetwork.Business.Abstract;
using SocialNetwork.Business.Concrete;
using SocialNetwork.Core.DataAccess.Concrete;
using SocialNetwork.DataAccess.Abstract;

namespace SocialNetwork.Business.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<UserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();
        }
    }
}