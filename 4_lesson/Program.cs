Console.WriteLine("Введите целое число");
int input1 = Convert.ToInt32(Console.ReadLine());
if (input1 > 0)
{
int input2 = - input1;
while (input2 <= input1)
{
    Console.WriteLine(input2);
    input2 ++ ;
}}

// input = -3 
else
{
int input3 = - input1;
while (input3 >= input1) // -3 >= 3 
{
    Console.WriteLine(input1); // -3 
    input1 ++ ;
}}