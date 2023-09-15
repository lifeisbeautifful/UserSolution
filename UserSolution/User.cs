namespace UserSolution
{
    public class User
    {
        public string FirstName { get; init; }
        public string Lastname { get; init; }
        public int Age { get; init; }
        public Enum Gender { get; set; }

        public User() { }
        public User(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            return Age < 10 ? $"Hi, my name is {FirstName} and last name {Lastname}." +
                              $"I am baby. I am {Gender}." 
                            :
                              $"Hi, my name is {FirstName} and last name {Lastname}." +
                              $"I am {Age} years old. I am {Gender}.";

        }
    }
}
