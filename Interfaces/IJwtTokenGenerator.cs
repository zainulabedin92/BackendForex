namespace BackendForex.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(string username);
    }
}
