//Определить количество строк, в которых присутствуют сочетания a*b, где * - любой символ.
class lab
{
    public static void Main(string[] args)
    {
       string n = Console.ReadLine();
       int Count = 0;
       while (n != "")
       {
            n = n.ToLower();
            for (int i = 0; i < n.Length-2; i++)
            {
                if (n[i] == 'a' && n[i+2] == 'b')
                {
                    Count++;
                }
            }
            n = Console.ReadLine();
        }
       Console.WriteLine(Count);
    }
}

//Определить максимальную длину подстроки в каждой строе, состоящей из сочетания abc