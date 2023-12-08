// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Logical IF ... ELSE ...
int a = 10;
int b = 10;
if (a > b)
{
    Console.WriteLine("Số a lớn hơn hoặc bằng số b");
}
else if (a < b)
{
    Console.WriteLine("Số a nhỏ hơn số b");
}
else
{
    Console.WriteLine("Hai số a, b bằng nhau");
}

// SWITCH ... CASE ...
int number = 2;
switch (number)
{
    case 1:
        Console.WriteLine("number có giá trị một");
    break;
    case 2:
        Console.WriteLine("number có giá trị hai");
    break;
    default:
        Console.WriteLine("number khác một và hai");
    break;
}