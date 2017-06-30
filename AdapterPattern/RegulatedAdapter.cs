using ExternalLibrary;

namespace AdapterPattern
{
    /// <summary>
    /// This adapts the interface and the power input.
    /// </summary>
    public class RegulatedAdapter : KoreanPlug
    {
        private readonly AmericanPlug _americanPlug;

        public RegulatedAdapter(AmericanPlug americanPlug)
        {
            _americanPlug = americanPlug;
        }

        public override bool ApplyPower(int voltage)
        {
            var regulatedVoltage = Regulate(voltage);

            // this is where the interface is adapted "ApplyPower" becomes "On"
            _americanPlug.On(regulatedVoltage);

            return true;
        }

        private static int Regulate(int voltage)
        {
            // this demonstrates any any additional "adaptation"
            return voltage > 120 
                ? 120 
                : voltage;
        }
    }
}