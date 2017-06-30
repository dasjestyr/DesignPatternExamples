using ExternalLibrary;

namespace AdapterPattern
{
    public class UnregulatedAdapter : KoreanPlug
    {
        private readonly AmericanPlug _americanPlug;

        public UnregulatedAdapter(AmericanPlug americanPlug)
        {
            _americanPlug = americanPlug;
        }

        public override bool ApplyPower(int voltage)
        {
            return _americanPlug.SupplyPower(voltage);
        }
    }
}