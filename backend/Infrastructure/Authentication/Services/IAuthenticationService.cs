namespace Backend.Infrastructure.Authentication.Services;

public interface IAuthenticationService
{
    string GetCurrentUserId();
    string GetCurrentUserEmail();
    bool IsAuthenticated();
    IEnumerable<string> GetUserRoles();
    Task<bool> ValidateTokenAsync(string token);
} 