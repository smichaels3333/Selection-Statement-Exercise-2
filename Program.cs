namespace SelectionStatementExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); //Evaluate to a string

            switch (subject)
            {
                case "Math";
                    Console.WriteLine("Math is tough!");
                    break;
                case "Science";
                    Console.WriteLine("Science is for smart people!");
                    break;
                case "English";
                    Console.WriteLine("I can't read!");
                    break;
                case "History";
                    Console.WriteLine("History is the best subject!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I have not taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}