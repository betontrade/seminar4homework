// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//____________________Домашнее задание__________________________


/*


Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

*/



//________________Задача 25_________________________________
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

int Stepen (int a, int b)
{
    int peremen = a;

    for (int i = 1; i < b; i++ )
    {
        a=a*peremen;  // 2*2 = 4  * 2 
    }
    return a;
}

Console.Write("пожалуйста введите число: ");

int num =Convert.ToInt32( Console.ReadLine());

Console.Write("пожалуйста введите степень: ");

int q = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Число "+ num + " в степени " + q + " равняется: " + Stepen(num, q));

*/

//________________Задача 27__________________
//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

int Dlinna (int n)

{
int i;
for (i = 1; n>10; i++)
{
    n=n / 10;
}

return i;
}


int Sum (int x, int y)
{
    int cifra = x;
    int colvocif = y;
    int pric = 1;
    int summaVs =0;

    while (colvocif > 0)
    {
        int count = pric;
        pric = pric*10;
        colvocif--;
        int simvol = cifra%pric/count;
        //Console.WriteLine(simvol);
        summaVs = summaVs+simvol;
    }
    //Console.WriteLine(summaVs);
    return summaVs;
}

Console.Write("пожалуйста введите число: ");
int nnn = Convert.ToInt32(Console.ReadLine());

int dl = Dlinna(nnn);

int sumsum = Sum(nnn, dl);

Console.WriteLine($"Сумма всех цифр числа {nnn} равняется {sumsum}. Конец программы");

*/

//________________________Задача 29_______________________________
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


