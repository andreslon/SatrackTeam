using SatrackTeam.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Infrastructure.Contracts
{
    public interface IApiService
    {
        Task<List<User>> ValidUser(User user);
        Task<List<Request>> GetRequests();
        Task SaveRequest(Request request);
    }
}
