#region bài 1
// int[] lstNumber = {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
// int total = 0;

// for (int i = 0; i < lstNumber.Length; i++)
// {
//     total += lstNumber[i];
// }

// System.Console.WriteLine("Tong so trong mang la:" + total);
#endregion


#region bài 2
// int[] lstNumber = {2, 7, 11, 15};
// int target = 9;

// int[] result = Methods.TwoSum(lstNumber, target);

// if (result.Length> 0)
// {
//     Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
// }else
// {
//     Console.WriteLine("ko co gia tri");
// }
#endregion

#region bài 3
// int[] nums = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
// int newLengthArr = Methods.RemoveDuplicates(nums);
// Console.WriteLine($"Do dai moi cua mang là: {newLengthArr}");
// Console.WriteLine($"Mảng mới là: [{string.Join(", ", nums.Take(newLengthArr))}]");
#endregion

#region bài 4
// int[] lstNumber = { 1, 1, 1, 2, 2 };
// int k = 2;
// List<int> result = Methods.TopKFrequent(lstNumber, k);
// Console.WriteLine($"Top {k} phần tử xuất hiện nhiều nhất: [{string.Join(", ", result)}]");
#endregion

#region bài 5
// int[] prices = { 7, 1, 5, 3, 6, 4 };
// int result = Methods.MaxProfit(prices);
// Console.WriteLine($"Lợi nhuận tối đa là: {result}");
#endregion

public class Program
{
    public static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Chọn bài tập để chạy (1-5), 0 để thoát:");
            Console.WriteLine("1. Tính tổng các số trong mảng");
            Console.WriteLine("2. Tìm hai số có tổng bằng target");
            Console.WriteLine("3. Loại bỏ các phần tử trùng lặp từ mảng đã sắp xếp");
            Console.WriteLine("4. Tìm k phần tử xuất hiện nhiều nhất");
            Console.WriteLine("5. Tính lợi nhuận tối đa từ việc mua và bán cổ phiếu");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Bài 1
                    int[] lstNumber1 = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
                    int total = 0;
                    for (int i = 0; i < lstNumber1.Length; i++)
                    {
                        total += lstNumber1[i];
                    }
                    Console.WriteLine("Tổng số trong mảng là: " + total);
                    break;

                case 2:
                    // Bài 2
                    int[] lstNumber2 = { 2, 7, 11, 15 };
                    int target = 9;
                    int[] result2 = Methods.TwoSum(lstNumber2, target);
                    if (result2.Length > 0)
                    {
                        Console.WriteLine($"Output: [{result2[0]}, {result2[1]}]");
                    }
                    else
                    {
                        Console.WriteLine("Không có giá trị nào.");
                    }
                    break;

                case 3:
                    // Bài 3
                    int[] nums3 = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
                    int newLengthArr = Methods.RemoveDuplicates(nums3);
                    Console.WriteLine($"Độ dài mới của mảng là: {newLengthArr}");
                    Console.WriteLine($"Mảng mới là: [{string.Join(", ", nums3.Take(newLengthArr))}]");
                    break;

                case 4:
                    // Bài 4
                    int[] lstNumber4 = { 1, 1, 1, 2, 2 };
                    int k = 2;
                    List<int> result4 = Methods.TopKFrequent(lstNumber4, k);
                    Console.WriteLine($"Top {k} phần tử xuất hiện nhiều nhất: [{string.Join(", ", result4)}]");
                    break;

                case 5:
                    // Bài 5
                    int[] prices = { 7, 1, 5, 3, 6, 4 };
                    int result5 = Methods.MaxProfit(prices);
                    Console.WriteLine($"Lợi nhuận tối đa là: {result5}");
                    break;

                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine(); // Dòng trống để dễ đọc
        } while (choice != 0);
    }
}
