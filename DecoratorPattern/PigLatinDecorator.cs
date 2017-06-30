using System.Linq;
using ExternalLibrary;

namespace DecoratorPattern
{
    public class PigLatinDecorator : Person
    {
        private readonly char[] _vowels = "aeiou".ToCharArray();

        public PigLatinDecorator(Person person)
            : base(person.FirstName, person.LastName)
        {
        }

        public override string GetIntroduction()
        {
            var words = base.GetIntroduction().Split(' ');
            var modifiedWords = words.Select(GetWord);
            return string.Join(" ", modifiedWords);
        }

        private string GetWord(string input)
        {
            var suffix = _vowels.Contains(input[0])
                ? "way"
                : $"{input[0]}ay";

            var prefix = input.Substring(1, input.Length - 1);
            return prefix + suffix;
        }
    }
}