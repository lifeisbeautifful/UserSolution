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
        
    }
}
