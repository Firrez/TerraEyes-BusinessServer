using TerraEyes_BusinessServer.Models;

namespace TerraEyes_BusinessServer.Services
{
    public interface IMeasurementDataTranslator
    {
        public void TranslateRawData(MeasurementRawInput input);
    }
}