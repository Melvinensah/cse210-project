namespace Sandbox
{
    public class Person
    {
        public string name;
        public string contact;
        public string address;

        public Person()
        {}

        public void DisplayPerson()
        {
            Console.WriteLine($"you are {name}, your contact is {contact} and you live at {address}");
        }

    }
}