// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());

int revNum = Num;
string strNum = revNum.ToString();
char[] arrNum = strNum.ToCharArray();
Array.Reverse(arrNum);
strNum = new string(arrNum);
revNum = Convert.ToInt32(strNum);

if(Num == revNum)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");