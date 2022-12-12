using AutoMapper;
using SocialNetwork.Core.Entities.Concrete;
using SocialNetwork.Entities.Concrete;
using static SocialNetwork.Entities.DTOs.PostDTO;
using static SocialNetwork.Entities.DTOs.UserDTO;

namespace SocialNetwork.Business.AutoMapper
{
    public class MappingProfile : Profile
    {
       public MappingProfile ()
       {
        CreateMap<LoginDTO, User>().ReverseMap();

        CreateMap<RegisterDTO,User>();
        CreateMap<User,RegisterDTO>();

        CreateMap<UserByEmailDTO,User>();
        CreateMap<User,UserByEmailDTO>();

        CreateMap<PostCreateDTO, Post>().ReverseMap();
        CreateMap<Post, PostDeleteDTO>().ReverseMap();

        CreateMap<ProfilePostLikeDTO, Post>().ReverseMap();
        CreateMap<ProfilePostDisLikeDTO, Post>().ReverseMap();
        }

    }
}