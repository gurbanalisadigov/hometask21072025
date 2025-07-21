
// Task1

int num1 = 27;
int num2 = 30;
int num3 = 30;

if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine(num1);

}
else if (num2 >= num1 && num2 >= num3)
{

    Console.WriteLine(num2);

}

else if (num3>= num1&& num3 >=num2)
{

    Console.WriteLine(num3);
}


    //task2

    int grade = 90;

if (grade >=0 && grade <= 100)
{
    if (grade >= 0 && grade <= 64)
    {
        Console.WriteLine("kesilmisiniz");
    }
    else if (grade >= 65 && grade <= 84)
    {
        Console.WriteLine("adi diplom almisiniz");
    }
    else if (grade >= 85 && grade < 95)
    {
        Console.WriteLine("sheref diplomu alib");
    }
    else if (grade >= 95 && grade <= 100)
    {
        Console.WriteLine("yuksek sheref diplomu almisiniz");
    }
}
else
{
    Console.WriteLine("ededlere bir daha baxin");

}

// Task 3
int num4 = 45;

int onluq = num4  / 10;
int teklik = num4 % 10;
int sum = onluq + teklik;


Console.WriteLine("mertebelerin cemi :" + sum);
