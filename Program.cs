using System;
using Utils;

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

        int numOne, numTwo, numThree; //All int can be initialized in the same line. We also change the variabe names so they are significative.

        //We ask the numbers to the user because a program with given numbers is useless.
        numOne = Tools.AskNumber();
        numTwo = Tools.AskNumber();
        numThree = Tools.AskNumber();

        Console.WriteLine(MsgWelcome); //We don't need to show the same message twice + we turn the messages into constants.

        Console.WriteLine(Tools.IsPositive(numOne, numTwo, numThree) ? MsgPositive : MsgZero);
        //We can skip the negative case because there's no possible negative result.

        // The next part of the code is useless + there's a while(true) and a commented variable, so we skip it.

        Console.WriteLine(MsgExit);
    }
}