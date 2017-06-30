using System;
using ExternalLibrary;

namespace DecoratorPattern
{
    internal class Program
    {
        /********************* DECORATOR PATTERN ******************************
         * Decorator pattern allows you to keep the existing interface but 
         * modify the original behavior of the object.
         * 
         * This allows the developer to preserve the original model while 
         * still being able to extend its functionality. This is useful when
         * you either do not have the ability to modify the original source,
         * or when doing so would complicate or contaminate the original model.
         **********************************************************************/

        private static void Main(string[] args)
        {
            var me = new Person("Jeremy", "Stafford");
            var pigLatinMe = new PigLatinDecorator(me);

            Doerator.Do(me, Console.WriteLine);
            Doerator.Do(pigLatinMe, Console.WriteLine);

            Console.ReadKey();
        }
    }
}
