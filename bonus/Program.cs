int lastnum()
{
    int x = new Random().Next(0,100000);
    Console.WriteLine(x);
    int x1=(x  % 10);
    int x2=(x % 100) % 10;
    int x3=(x % 1000) % 10;
            if (x > 0 && x < 100)
            {
            return(x1);
            }
            else if (x > 100 && x < 1000)
            {
            return(x2);
            }
            else if (x > 1000 && x < 10000);
            {
            return(x3);
            }
}
Console.WriteLine (lastnum());



string programist(lastnum());
{
    if (lastnum() = x1) Console.WriteLine ($"{x} програмист");
    else if (lastnum() = x2) Console.WriteLine ($"{x} програмиста");
    else (lastnum() = x3) Console.WriteLine ($"{x} програмистов");
   
}
Console.WriteLine(programist(lastnum());

