using SocialNetwork.Core.Entities.Concrete;

namespace SocialNetwork.Entities.Concrete
{
    public class   Reaction
    {
         public int Id { get; set; }
         public Guid UserId { get; set; }
         public virtual User User { get; set; }
         public int PostId { get; set; }
         public virtual Post Post { get; set; }
         public bool IsLike { get; set; }
    }
}