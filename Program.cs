using System;


for (int x = 0; x < 100; x++)
{
    bool yes;
    yes = true;


    if (yes)
    {
        Console.WriteLine("Enter some text: ");

        string str = Console.ReadLine();
        string newStr = str.Remove(10);

        Console.WriteLine(newStr);
        Console.WriteLine("-------------------------------------");

        

        Console.WriteLine("write a sentance: ");
        string mystring = Console.ReadLine();

        for (int i = 0; i < mystring.Length; i++)
        {

            string[] words = mystring.Split(' ');

            Console.WriteLine(mystring[i]);
        }
        Console.Read();
      

        Console.WriteLine("Would you like to continue (yes/no) \n");
        yes = bool.Parse(Console.ReadLine());
    }
    else
        Console.WriteLine("Goodbye!");

}










