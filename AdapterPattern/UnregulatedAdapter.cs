using ExternalLibrary;

namespace AdapterPattern
{
    /// <summary>
    /// This simply adapats the interface.
    /// </summary>
    public class UnregulatedAdapter : KoreanPlug
    {
        private readonly AmericanPlug _americanPlug;

        public UnregulatedAdapter(AmericanPlug americanPlug)
        {
            _americanPlug = americanPlug;
        }

        public override bool ApplyPower(int voltage)
        {
            // this is where the interface is adapted "ApplyPower" becomes "On"
            return _americanPlug.On(voltage);
        }
    }
}