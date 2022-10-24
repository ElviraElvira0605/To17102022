// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// Например:
// 6 -> да;
// 7 -> да;
// 1 -> нет;

Console.Write ( "Введите число: ");
int a  = Convert.ToInt32 ( Console.ReadLine ());

switch (a);

{
    case 1: case 2: case 3: case 4: case 5:
    Console.WriteLine (" Нет ");
    break;

    case 6: case 7:
    Console.WriteLine (" Да ");
    break;

    default :
    Console.WriteLine (" Такого дня недели не существует ");
    break;

}

   

