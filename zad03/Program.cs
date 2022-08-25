// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


string weekendday()
{
    Console.WriteLine ("Введите номер числа недели");
    int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 5)
        {
            return ("Это рабочий день");
        }
        else if  (n > 7)
        {
            return ("В неделе 7 дней. Сходите на курсы GeekBrains!!!");  
        }  
        else 
        {
            return ("Это выходной день");
        }
}
Console.WriteLine (weekendday());