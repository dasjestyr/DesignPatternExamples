using System;
using ExternalLibrary;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var koreanOutlet = new KoreanWallOutlet();

            TryKoreanPlug(koreanOutlet);

            var americanPlug = new AmericanPlug();

            // won't compile because wrong plug/doesn't fit the interface
            //outlet.PlugIn(americanPlug);

            //TryAdapter1(koreanOutlet, americanPlug);
            //TryAdapter2(koreanOutlet, americanPlug);

            Console.ReadKey();
        }

        private static void TryKoreanPlug(KoreanWallOutlet outlet)
        {
            var koreanPlug = new KoreanPlug();

            outlet.PlugIn(koreanPlug);
            var powerApplied = outlet.ApplyPower();
            if (powerApplied)
                Console.WriteLine("Used Korean Plug. Device turned on.");
        }

        private static void TryAdapter1(KoreanWallOutlet outlet, AmericanPlug americanPlug)
        {
            try
            {
                // the voltages don't match so this won't work either
                var adapter1 = new UnregulatedAdapter(americanPlug);
                outlet.PlugIn(adapter1);
                outlet.ApplyPower(); // boom
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Used unregulated adapter. {ex.Message}");
            }
        }

        private static void TryAdapter2(KoreanWallOutlet outlet, AmericanPlug americanPlug)
        {
            var adapter2 = new RegulatedAdapter(americanPlug);
            outlet.PlugIn(adapter2);
            var powerApplied = outlet.ApplyPower();
            if (powerApplied)
                Console.WriteLine("Used regulated adapter Device turned on.");
        }
    }
}
