using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PolarStar.Controllers;

namespace PolarStar.Services
{
    public class AuthService: IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<AuthService> _logger;
        private readonly HttpClient _client;

        public AuthService(ILoggerFactory loggerFactory, IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            _logger = loggerFactory.CreateLogger<AuthService>();
            _configuration = configuration;
            _clientFactory = clientFactory;
            _client = _clientFactory.CreateClient();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client.DefaultRequestHeaders.Add("user-agent", "PolarStar phone auth");
        }
        public Task SendCode(string phoneNumber, string countryCode)
        {
            throw new System.NotImplementedException();
        }

        public Task VerifyCode(string phoneNumber, string countryCode, string token)
        {
            throw new System.NotImplementedException();
        }
    }
}