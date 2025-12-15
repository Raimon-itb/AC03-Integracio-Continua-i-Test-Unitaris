using System;

class Program
{
    static void Main() //We skip the string[] args because we won't need terminal arguments
    {
        //usunesVAr isn't used, so we can skip it

        // We translate every message to English
        const string MsgWelcome = "Welcome to calculation program!";
        const string MsgZero = "The result is zero";
        const string MsgPositive = "The result is positive";
        const string MsgExit = "Ending the program...";

        int a = 5, b = 10, c = 15, result = 0; //All int can be initialized in the same line.

        Console.WriteLine(MsgWelcome); //We don't need to show the same message twice + we turn the messages into constants.

        if (a > 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    result = a + b + c;
                } else
                {
                    result = a + b;
                }
            } else
            {
                result = a;
            }
        } else
        {
            result = 0;
        }
        
        switch (result)
        {
            case 0:
                Console.WriteLine(MsgZero);
                break;
            case 1: 
                Console.WriteLine(MsgPositive);
                break;
            //We can skip the negative case because there's no possible negative result.
        }

        // The next part of the code is useless + there's a while(true) and a commented variable, so we skip it.

        Console.WriteLine(MsgExit);
    }
}