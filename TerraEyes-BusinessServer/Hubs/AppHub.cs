using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using TerraEyes_BusinessServer.DBNetworking;

namespace TerraEyes_BusinessServer.Hubs
{
    public class AppHub : Hub
    {
        private IDbConnect DbConnect;
        public AppHub()
        {
            DbConnect = new DbConnection();
        }

        public async Task<List<int>> TemperatureDataFromDataToAndroid(string userId)
        {
            return await DbConnect.GetTemperaturePointFromDb(userId);
        }
    }
}