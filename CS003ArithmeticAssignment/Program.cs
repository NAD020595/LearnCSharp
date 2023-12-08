// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Độ ưu tiên từ cao xuống thấp là: 1 trong ngoặc (), 2 số mũ - căn, 3 nhân hoặc chia * /, 4 cộng hoặc trừ + -

// Phép cộng +, phép trừ -
int a = 28;
int b = 10;
Console.WriteLine(a + b);  // In ra: 38
Console.WriteLine(a - b);  // In ra: 18

// Phép nhân *
float a = 1.2f;
int b = 3;
Console.WriteLine(a * b);  // In ra 3.6

// Phép chia /
float a = 1.2f;
int b = 3;
Console.WriteLine(a / b);  // In ra 0.4

int a = 10;
int b = 3;
Console.WriteLine(a / b);          // In ra 3  // Nếu số chia và số bị chia thì phép toán / sẽ lấy phần nguyên. Nếu muốn lấy giá trị thực chính xác, cần chuyển số chia, hoặc bị chia thành số thực.
Console.WriteLine(a / (float)b);   // In ra 3.333333 // Chuyển số chia thành số thực

// Phép chia lấy dư %
int a = 8;
int b = 3;
Console.WriteLine(a % b);  // In ra 2

// Toán tử tăng ++ và giảm -- trong C#
int a = 10;
a++;    // a là 11 (thêm 1)
++a;    // a là 12 (thêm 1)

a--;    // a là 11 (bớt 1)
--a;    // a là 10 (bớt 1)