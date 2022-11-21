namespace SocialNetwork.Entities.DTOs
{
    public class UserDTO
    {
    public record LoginDTO(string Email, string Password);
    public record RegisterDTO(string Name, string SurName,string Email,string UserName,string Password,DateTime BirthDay);
    public record UserByEmailDTO(string Name, string SurName,string Email,string UserName,DateTime BirthDay );
}   
}