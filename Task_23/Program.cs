/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
int number = Convert.ToInt16(Console.ReadLine());

void Method3( int number)
{
    for (int i = 0; i < number+1 ; i ++)
    {
         for (int j = 0; j < number+1 ; j ++)
         {
            if (i ==j)
            {
                Console.WriteLine ($"{i}x{j} ={j*i*i}");
            }
         }

    }

}
Method3(number);


