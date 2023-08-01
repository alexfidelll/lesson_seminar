System.Console.WriteLine("Введите число");

int numberOfWeek = Convert.ToInt32(Console.ReadLine());

if (numberOfWeek == 1) Console.WriteLine("Понедельник");
if (numberOfWeek == 2) Console.WriteLine("Вторник");
if (numberOfWeek == 3) Console.WriteLine("Среда");
if (numberOfWeek == 4) Console.WriteLine("Четверг");
if (numberOfWeek == 5) Console.WriteLine("Пятница");
if (numberOfWeek == 6) Console.WriteLine("Суббота");
if (numberOfWeek == 7) Console.WriteLine("Воскресенье");
if (numberOfWeek > 7) Console.WriteLine("Нет такого дня недели");
