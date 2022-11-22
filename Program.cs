using System;
using LegitBankApp.Implementations;
using LegitBankApp.Menu;
using LegitBankApp.Model;

namespace LegitBankApp
{
    class Program
    {


        static void Main(string[] args)
        {
            string y = @"

        ###########################################################################
        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
        ####___________________________________________________________________####
        ####     ZZZZZZZZZZ EEEEEEEE  NN      NN   II  TTTTTTTTTT HH    HH     ####
        ####                                                                   ####
        ####          ZZ    EE        NN NN   NN   II      TT     HH    HH     ####
        ####        ZZ      EEEEEEEE  NN  NN  NN   II      TT     HHHHHHHH     ####
        ####      ZZZ       EE        NN   NN NN   II      TT     HH    HH     ####
        ####   ZZZZZZZZZZ   EEEEEEEE  NN      NN   II      TT     HH    HH     ####
        ####___________________________________________________________________####
        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
        ###########################################################################";
            System.Console.WriteLine($"\t\t{y}");
            Console.WriteLine($"\n______________________________________________________________________________\n");






            var viewMenu = new ViewMenu();
            viewMenu.OverAll();
            

           


           




























        }
    }
}
