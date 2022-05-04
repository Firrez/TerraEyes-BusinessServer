using System.Collections.Generic;
using System.Threading.Tasks;

namespace TerraEyes_BusinessServer.DBNetworking
{
    public interface IDbConnect
    {
        Task<List<int>> GetTemperaturePointFromDb(string userId);
    }
}