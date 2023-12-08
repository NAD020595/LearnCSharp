// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int seconds = 60;                    //khai báo biến số nguyên
double so_pi = 3.14;                 //khai báo biến số thực
bool deltaIsSezo = true;             //Khai báo biến logic
char chooseAction = 'S' ;            //Khai báo biến kiểu ký tự
string msgResult = "Kết quả giải:" ; // khai báo biến chuỗi

// int kiểu số nguyên (có dấu, dùng 32 bit biểu diễn, từ -2,147,483,648 đến 2,147,483,647)
// sbyte kiểu số nguyên (có dấu, dùng 8 bit biểu diễn, từ -128 đến 127)
// byte kiểu số nguyên (không dấu, dùng 8 bit biểu diễn, từ 0 đến 255)
// short kiểu số nguyên (có dấu, dùng 16 bit biểu diễn, từ -32,768 đến 32,767)
// ushort kiểu số nguyên (không dấu, dùng 16 bit biểu diễn, từ 0 đến 65,535)
// long kiểu số nguyên (có dấu, dùng 64 bit biểu diễn, từ -9,223,372,036,854,775,808 đến 9,223,372,036,854,775,807)
// ulong kiểu số nguyên (không dấu, dùng 64 bit biểu diễn, từ 0 đến 18,446,744,073,709,551,615)
// float số thực chấm động (dùng 32 bit biểu diễn phù hợp số có bảy chữ số, độ chính xác số dấu chấm động 1.5 × 10−45 đến 3.4 × 1038)
// double số thực chấm động (dùng 64 bit biểu diễn)
// decimal số thực chấm động (dùng 128 bit biểu diễn)
// char một ký tự (dùng 16 bit biểu diễn ký tự Unicode)
// bool kiểu logic (chỉ nhận giá trị false hoặc true)
// string chuỗi (xâu) ký tự (tập hợp các ký tự theo thứ tự - một văn bản text)
// object đối tượng, biểu diễn các đối tượng C#, nó là kiểu cơ sở - mọi đối tượng C# đều kế thừa từ kiểu này.

Console.WriteLine();                                                //Xuống dòng
Console.WriteLine();                                                //Xuống dòng

Console.ForegroundColor = ConsoleColor.DarkMagenta;                 //Đặt màu chữ
Console.WriteLine("XIN CHÀO - CHƯƠNG TRÌNH NHẬP XUẤT DỮ LIỆU");     //In dòng chữ
Console.ResetColor();                                               //Reset màu

Console.Write("Giá trị biến so_pi là : ");                          //In dòng chữ
Console.WriteLine(so_pi);                                           //In giá trị biến
Console.WriteLine();                                                //Xuống dòng

// NHẬP DỮ LIỆU
string userLogin;
Console.Write("Nhập username : ");
userLogin = Console.ReadLine();
Console.WriteLine($"Tên nhập vào là: {userLogin}");

// THAY ĐỔI KIỂU DỮ LIỆU
// Convert.ToInt32(value) chuyển value thành kiểu int
// Convert.ToDouble(value) chuyển value thành kiểu double
// Convert.ToBoolean(value) chuyển value thành kiểu bool

Console.Write("Nhập một số thức : ");
// Nhập chuỗi - chuyển ngay chuỗi đó thành số thực
double dinput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Số đã nhập là: {dinput}");

// Khai báo biến kiểu ngầm định với var

// Hằng số trong C#
const string MON = "THỨ HAI";
Console.WriteLine(MON);