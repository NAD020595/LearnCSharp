// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Trong vòng lặp, nếu gặp break vòng lặp sẽ thoát ngay lập tức - và chuyển đến các câu lệnh sau vòng lặp.
// Trong vòng lặp, nếu gặp continue thì tương đương việc đến cuối khối lệnh của lần lặp đó (bắt đầu thực hiện lần lặp mới ngay).

for (int i = 8;i <=10;i++)
{
    Console.WriteLine("Số i = " + i);
}
// Số i = 8
// Số i = 9
// Số i = 10

// =========================================================================


// In ra các số chẵn
int j = 10;
do
{
    Console.WriteLine("Số j = " + j);
    j += 2;
}
while (j <=20);
        
// Số j = 10
// Số j = 12
// Số j = 14
// Số j = 16
// Số j = 18
// Số j = 20

// =========================================================================

 //In ra các số chia hết cho 3
for (int i = 10; i <= 20; i ++ )
{
    if (i % 3 != 0)
        continue;  // Chạy ngay vòng lặp tiếp
    Console.WriteLine("Số i = " + i);
} 
// Số i = 12
// Số i = 15
// Số i = 18

// =========================================================================

int i = 0;
while (true)
{
    Console.Write(" " + ++i);
    if (i == 10)
        break;  // Thoát lặp
} 
// 1 2 3 4 5 6 7 8 9 10