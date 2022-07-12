// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да

// 23432 -> да

int number = Convert.ToInt32(Console.ReadLine());

string method1 (int number ) 
{

    if( (number % 10 == number/10000)&&(number % 100 / 10) == (number/1000 % 10) )
    {
       return "да ";

       
    }
    
       return "нет ";
       
    
    
}

 method1 ( number) ;
 
 Console.WriteLine( method1 ( number));
