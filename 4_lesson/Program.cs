Console.WriteLine("Введите целое число");
int input1 = Convert.ToInt32(Console.ReadLine());
int input2 = - input1;
if (input1 > 0)
{
while (input2 <= input1)
{
    Console.WriteLine(input2);
    input2 ++ ;
}}
else
{
    while (input1 <= input2)
{
    Console.WriteLine(input1);
    input1 ++ ;
}}q