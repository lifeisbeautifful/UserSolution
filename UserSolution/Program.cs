using UserSolution;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();

        while (int.TryParse(firstName, out int result) || string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("first name cannot be empty or contain numbers.");
            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
        }

        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        while (int.TryParse(lastName, out int result) || string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("last name cannot be empty or contain numbers.");
            Console.WriteLine("Enter last name: ");
            lastName = Console.ReadLine();
        }

        User user1 = new User(20)
        {
            FirstName = firstName,
            Lastname = lastName,
        };

        Console.WriteLine(user1.ToString());
    }
}