using System.Threading.Tasks;

namespace PolarStar.Services
{
    public interface IAuthService
    {
        Task SendCode(string phoneNumber, string countryCode);
        Task VerifyCode(string phoneNumber, string countryCode, string token);
    }
}