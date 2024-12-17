var part1 = new Part1();
Console.WriteLine("Task1");
part1.task1Convert57();
Console.WriteLine("Task2");
part1.task2BinaryConvert("1101");
Console.WriteLine("Task3");
part1.task3DeToBinaryConvert(100);
Console.WriteLine("Task4");
part1.task416to10and2("2F");
Console.WriteLine("Task5");
part1.task5sPowerOfTwo();

var part2 = new Part2();
part2.findEveAndOdd();
class Part1
{
    public void task1Convert57()
    {
        var n = 57;
        Console.WriteLine(Convert.ToString(n, 2));
        Console.WriteLine(Convert.ToString(n, 8));
        Console.WriteLine(Convert.ToString(n, 16));
    }

    public void task2BinaryConvert(string number)
    {
        var binary = Convert.ToInt32(number, 2);
        Console.WriteLine(binary);
    }

    public void task3DeToBinaryConvert(int number) 
    {
        string binary = "";

        while (number > 0)
        {
            int remainder = number % 2;
            binary += remainder;
            number /= 2;
        }
        
        Console.WriteLine(binary);
    }

    public void task416to10and2(string hexNumber)
    {
        var dec = Convert.ToInt32(hexNumber, 16);
        var binary = Convert.ToString(dec, 2);
        
        Console.WriteLine(dec);
        Console.WriteLine(binary);
        
    }

    public void task5sPowerOfTwo()
    {
        for (int i = 0; i <= 8; i++)
        {
            Console.WriteLine(Math.Pow(2, i));
        }
    }
}

class Part2
{
    public void findEveAndOdd()
    {
        Console.Write("Enter a decimal number: ");
        var number = int.Parse(Console.ReadLine());
        var binary = Convert.ToString(number, 2);
        Console.WriteLine(binary);
        string evenBits = "";
        string oddBits = "";

        for (var i = 0; i < binary.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenBits += binary[i];
            }
            else
            {
                oddBits += binary[i];
            }
        }
        
        Console.WriteLine("Even bits " + evenBits);
        Console.WriteLine("Odd bits " + oddBits);
    }
}