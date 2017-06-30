namespace ExternalLibrary
{
    public class Person
    {
        public readonly string FirstName;
        public readonly string LastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string GetIntroduction()
        {
            return $"Hello my name is {FirstName} {LastName} and it is nice to meet you";
        }
    }
}
