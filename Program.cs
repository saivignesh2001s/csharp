// See https://aka.ms/new-console-template for more information
int i=0, j=0, k=0, userchoice;
char ch=' ';
Console.WriteLine("Menu\n 1.Add\n 2.Subtract\n 3.Exit");
userchoice=Convert.ToInt32(Console.ReadLine());
if(userchoice<4)
{
    i = Convert.ToInt32(Console.ReadLine());
    j = Convert.ToInt32(Console.ReadLine());
}
switch (userchoice)
{
    case 1:
        ch = '+';
        k = i + j;
        break;
    case 2:
        ch = '-';
        if (i > j)
            k = i - j;
        else
            k = j - 1;
        break;
    case 3:
        Environment.Exit(0);
        break;
    default:
        Environment.Exit(-1);
        break;
}
Console.WriteLine("{0}{1}{2}={3}", i, ch, j, k);
Console.ReadLine();
