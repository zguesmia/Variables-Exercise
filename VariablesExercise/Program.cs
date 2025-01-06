namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Zach";
            int age = 28;
            char courseGrade = 'A';
            bool truth = true;
            double courseGrade2 = 92.1;

            Console.WriteLine("Hello, my name is " + name);
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("Last semester, it is " + truth + "I took two courses and got an " + courseGrade + " in each one.");
            Console.WriteLine("In my Spanish class, my grade was a " +  courseGrade2);
        }
    }
}
