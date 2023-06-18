// Расчёт квадрата числа
// Convert.ToInt32(Console.ReadLine()) - функция для чтения чисел (перевод строки в число)
// $ - ссылка на переменные
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int quater = number * number;
Console.WriteLine($"Квадрат числа {number} равен {quater}");