using System;

namespace ExternalLibrary
{
    public static class Doerator
    {
        public static void Do(Person person, Action<string> action)
        {
            action(person.GetIntroduction());
        }
    }
}
