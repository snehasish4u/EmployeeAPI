using System.Collections.Generic;
using System.Security.Claims;

namespace EmployeeFinance
{
    public interface IJwtAuthenticationManager
    {
        AuthenticationResponse Authenticate(string userName, string password);
        AuthenticationResponse RefreshToken(RefreshTokenInfo refreshTokenInfo);
    }
}
