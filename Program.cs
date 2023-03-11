namespace WhileLoop;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int count = 1;
        int sum = 0;
        
        while (count <= number)
        {
            sum += count;
            count++;
        }
        Console.WriteLine("Avarage is : " + sum/number);

        //------------------

        char c = 'a';
        while (c <= 'z')
        {
            Console.Write(c);
            c++;
        }
        Console.WriteLine("");
        
        //-------foreach------

        string[] cars = {"Bmw", "Audi", "Mercedes", "WW"};

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
