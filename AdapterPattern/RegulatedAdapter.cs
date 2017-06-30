using ExternalLibrary;

namespace AdapterPattern
{
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
            _americanPlug.SupplyPower(regulatedVoltage);
            return true;
        }

        private static int Regulate(int voltage)
        {
            return voltage > 120 
                ? 120 
                : voltage;
        }
    }
}