using System;

namespace EmployeeFinance
{
    public class AuthenticationResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expires { get; set; }
    }

    public class RefreshTokenInfo
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
