// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Khởi tạo mảng
int[] bienMang; // khai báo biến mảng kiểu phần tử là int (chưa khởi tạo)
bienMang  = new int[5]; 

string[] studentNames = new string[10]; // có thể khởi tạo ngay khi khai báo int[] bienMang = new int[5];

string[] productNames = new string[3] {"Iphone", "Samsung", "Nokia"}; // mảng 3 phần tử chuỗi ký tự, mỗi phần tử được gán ngay giá trị chuỗi cụ thể

double[] productPrices = new double[3] {100, 200.5, 10.1}; // mảng 3 phần tử double, mỗi phần tử được gán giá trị luôn

// Truy cập phần tử mảng
int[] myArray = {1,3,5,19};
int a = myArray[2]   // đọc phần tử chỉ số 2 (phần tử thứ 3) của mảng =  5
myArray[3] = 100;   // Gán 100 vào phần tử có chỉ số 3, 19 thay thế bởi 100

// Length	Thuộc tính cho biết số lượng phần tử trong mảng
// Rank	Thuộc tính cho biết số chiều mảng
// Clone()	Copy (nhân bản) đối tượng mảng
// GetValue(index)	Lấy giá trị phần tử trong mảng
// Min()	Trả về giá trị nhỏ nhất trong mảng
// Max()	Trả về giá trị lớn nhất trong mảng
// Sum()	Trả về giá trị tổng cộng các phần tử

// Array.BinarySearch(array, value)	Tìm kiếm phần tử trong mảng đã được sắp xếp, trả về chỉ số nếu tìm thấy
// CopyTo(array, indexStart)	Sao chép phần tử mảng này sang mảng khác
// Array.Clear(array, index, length)	Thiết lập phần tử mảng nhận giá trị mặc định
// bool Exists<T> (array, Predicate<T> match);	Kiểm tra có phần tử trong mảng thỏa mãn match
// Fill<T> (array, value);	Gán các phần tử của mảng bằng value
// T Find<T> (array, Predicate<T> match);	Tìm phần tử mảng
// int FindIndex<T> (array, Predicate<T> match);	Tìm phần tử mảng, trả về chỉ số nếu thấy
// T[] FindAll<T> (array, Predicate<T> match);	Tìm tất cả phần tử mảng
// int IndexOf(array, value)	Tìm chỉ số của phần tử
// ForEach(array, Action<T> action)	Thi hành action trên mỗi phần tử
// Sort(array)	Sắp xếp

// Duyệt qua các phần tử mảng
int[] myArray = {1,3,5,19, 10, 20, 40, 40};
int maxIndex = myArray.Length - 1;
for (int idx = 0; idx <= maxIndex; idx ++) {
    Console.WriteLine(myArray[idx]);
}

// Mảng nhiều chiều (rank)
int[,] myvar = new int[3,4];
myvar[0,0] =  1;    // hàng 1, cột 1
myvar[2,3] =  3;    // hàng 3, cột 4

int[,] myvar = new int[3,4] {{1,2,3,4}, {0,3,1,3}, {4,2,3,4}};          // khai báo và khởi tạo mảng 2 chiều

for (int i = 0; i <= 2; i ++)                                           // duyệt qua từng hàng
{
    for(int j = 0; j <=3; j++)                                          // duyệt qua từng cột
    {
        Console.Write(myvar[i,j] + " ");
    }
    Console.WriteLine();
}

// Mảng trong mảng
 int[][] myArray = new int[][] {
                                new int[] {1,2},
                                new int[] {2,5,6},
                                new int[] {2,3},
                                new int[] {2,3,4,5,5}
                               };

foreach (var arr in myArray) {
    foreach (var e in arr) {
        Console.Write(e + " ");
    }
    Console.WriteLine();
}
