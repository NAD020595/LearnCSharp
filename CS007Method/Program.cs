// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double bp = BinhPhuong(5); // Gọi hàm
Console.WriteLine("Bình phương của 5 là: " + bp);


/// Tính bình phương của số thực double
static double BinhPhuong(double number)
{
    double ketqua = number * number;
    return ketqua;
}

// Phương thức khai báo có 3 tham số, hai tham số cuối mặc định
// Nếu gọi hàm không có chỉ ra tham số cuỗi thì nó lấy giá trị mặc định này
static double TheTich(double cao, double dai = 1, double rong = 1)
{
     return cao * dai * rong;
}

// Truyền tham số tham chiếu và tham trị C#
// Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu

// tham trị là cách thức mặc định, ta đã sử dụng ở phần trên. Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ, còn bản thân biến bên ngoài không hề ảnh hưởng.
// tham chiếu thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, nên nó có tác động trực tiếp đến biến này bên ngoài. Để sử dụng được tham chiếu thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref\

// Phương thức Đệ quy

static int giaithua(int a) {
    if (a == 1)
        return 1; // Kết thúc đệ quy

    return
        a * giaithua (a - 1);  // Đệ quy
}

Console.WriteLine(giaithua(5)); //120