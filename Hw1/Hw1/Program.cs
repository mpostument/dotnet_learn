// Part 1. Find Mistakes

string numberString = "123"; // a removed
int number = Convert.ToInt32(numberString);

double value = 12.56;
int result = (int)value + (int)0.5; // Converted 0.5 to int

int a = 5;  
int b = 3;  
int result2 = a & b; // From && to &

double number2 = 3.14;
float floatNumber = (float)number2; // Replace Convert with (float)

long number3 = 10; 
long shifted = number3 << 32; // Because int is 32 bit long. And not possible to do shift

// Part 2 Simple tasks

var part2 = new Part2();
part2.Task1();
part2.Task2EvenOrOdd(32);
part2.Task3Shift16(2);
part2.Task4Xor(10, 2);
part2.Task5StringToInt();

var part3 = new Part3();
part3.PrintHeroPowers();
part3.EnableSkill(2);
part3.EnableSkill(4);
part3.PrintHeroPowers();
part3.DisableSkill(4);
part3.PrintHeroPowers();
class Part2
{
    public void Task1()
    {
        var num = 256;
        var numToString = num.ToString();
    }

    public void Task2EvenOrOdd(int num)
    {
        if ((num & 1) == 0)
        {
            Console.WriteLine("The numver is even");
        }
        else
        {
            Console.WriteLine("The numver is odd");
        }
    }

    public void Task3Shift16(int num)
    {
        var result = num << 4;
        Console.WriteLine(result);
    }

    public void Task4Xor(int num1, int num2)
    {
        var result = num1 ^ num2;
        Console.WriteLine(result);
    }

    public void Task5StringToInt()
    {
        var result = Convert.ToInt32("1001");
        Console.WriteLine(result);
    }
}

// Part 3 Practical 
class Part3
{
    private int skills = 0;

    public void EnableSkill(int skillNumber)
    {
        skills |= (1 << (skillNumber - 1));
    }

    public void DisableSkill(int skillNumber)
    {
        skills &= ~(1 << (skillNumber - 1));
    }

    public bool isSkillEnabled(int skillNumber)
    {
        return (skills & (1 << (skillNumber - 1))) != 0;
    }

    public void PrintHeroPowers()
    {
        Console.WriteLine($"Current Skills: {Convert.ToString(skills, 2).PadLeft(8, '0')}");
    }
}