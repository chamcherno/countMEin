namespace API.DTOs;

public class RegisterDto : LoginDto
{
    public string DisplayName { get; set; }
    public string Username { get; set; }

}
