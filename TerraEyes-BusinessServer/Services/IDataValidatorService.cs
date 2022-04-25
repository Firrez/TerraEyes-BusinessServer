using TerraEyes_BusinessServer.Models;

namespace TerraEyes_BusinessServer.Services
{
    public interface IDataValidatorService
    {
        public void ValidateMeasurementData(Measurement measurement);
    }
}