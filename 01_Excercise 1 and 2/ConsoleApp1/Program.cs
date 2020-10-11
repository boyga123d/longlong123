using System;

public class Program
{
	public static void Main()
	{
		string name;
		Console.WriteLine("Nhap vao ten cua ban : ");
		name = Console.ReadLine();
		Console.WriteLine("Ten cua ban la {0}  ",name);
		//nhập vào 2 số nguyên tính tổng 2 số vừa nhập.
		Console.WriteLine("Nhap vao so nguyen thu nhat: ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Nhap vao so nguyen thu hai: ");
		int b = int.Parse(Console.ReadLine());
		int kq1 = a + b;
		int kq2 = a * b;
		int kq31 = a / b;
		int kq32= b / a;
		int kq41 = a - b;
		int kq42 = b - a;
		int chon;
		Console.WriteLine("{0} + {1} = {2} ", a, b, kq1);
		Console.WriteLine("{0} x {1} = {2} ", a, b, kq2);
		do
		{
			Console.WriteLine("Chọn chức năng : [1- 4]");
			Console.WriteLine("1.A-B");
			Console.WriteLine("2.B-A");
			Console.WriteLine("3.A:B");
			Console.WriteLine("4.B:A");
			Console.WriteLine("5.Thoat Menu");
			chon = int.Parse(Console.ReadLine());
			switch (chon)
			{
				case 1:
					Console.WriteLine("{0} - {1} = {2} ", a, b, kq41);
					break;
				case 2:
					Console.WriteLine("{0} - {1} = {2} ", b, a, kq42);
					break;
				case 3:
					Console.WriteLine("{0} : {1} = {2} ", a, b, kq31);
					break;
				case 4:
					Console.WriteLine("{0} : {1} = {2} ", b, a, kq32);
					break;
				case 5:
					break;

				default:
					Console.WriteLine("vui long nhap lai");
					break;
			}
		} while (chon != 5);
		Console.WriteLine("bam phim bat ky de end");
		Console.ReadLine();
	}
}