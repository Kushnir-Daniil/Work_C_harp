using System;
class Math {
	static void Main() {
	    Console.Write("Введіть два цілих Числа\n");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
        Console.Write("Множення\n");
		Console.WriteLine(a*b);
		Console.Write("Середнє арифметичне\n");
		Console.WriteLine((a+b)/2);
        Console.Write("Числа Фібоначі\n");
		int end = int.Parse(Console.ReadLine());
		int j=1;
		for (int i = 1; i <= end; i += j) {
			Console.Write("{0} ", i);
			j = i - j;
		}
	}

}
