namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Henry";
            int dogAge = 8;
            char exclamationPoint = '!';
            bool isCute = true;
            double time = 5.5;
            decimal money = 10000.242m;


            Console.WriteLine($"My dog {dogName} is {dogAge} years old. " +
                $"He loves to nap all day {exclamationPoint} " +
                $"It's {isCute} that he is cute. " +
                $"He loves to run and can achieve speeds of {time} miles per hour." +
                $" {dogName} eats {money} per year in dog food.");
        }
    }
}
