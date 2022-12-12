public class Add
{

    public static void main(String[] args)
    {

        int a = Int32.Parse(args[0]);
        int b = Int32.Parse(args[1]);

        int sum = a + b;

        Console.WriteLine("Sum is " + sum);
    }
}