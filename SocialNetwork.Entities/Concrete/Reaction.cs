using SocialNetwork.Core.Entities.Concrete;

namespace SocialNetwork.Entities.Concrete
{
    public class   Reaction
    {
         public int Id { get; set; }
         public Guid UserId { get; set; }
         public User User { get; set; }
         public int PostId { get; set; }
         public Post Post { get; set; }
         public bool IsLike { get; set; }
    }
}