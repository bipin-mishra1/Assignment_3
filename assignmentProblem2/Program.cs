using System;
using StringManipulation;
namespace Program{
    class MainProgram
    {
        public static void Main(string[] args){
                //1
                Console.WriteLine("\nEnter a string : ");
                String str = Console.ReadLine()??throw new Exception();
                Console.WriteLine($"\'{str}\' has length : {StringManips.Length(str)}");
                
                //2
                Console.WriteLine("\nEnter a sentence : ");
                String sentence = Console.ReadLine()??throw new Exception();

                if(StringManips.isDeclarative(sentence)){
                    Console.WriteLine("It is a declarative sentece");
                }else if(StringManips.isExclamation(sentence)){
                    Console.WriteLine("It is a Exclamatory sentece");
                }else if(StringManips.isInterrogative(sentence)){
                    Console.WriteLine("It is a interrogative sentece");
                }

                //3
                Console.WriteLine("\nEnter a name, having first name and last name: ");
                String name = Console.ReadLine()??throw new Exception();
                StringManips.PrintName(name);
                //4
                Console.WriteLine("\nEnter a name : ");
                String sname = Console.ReadLine()??throw new Exception();
                StringManips.EnhancedPrintName(sname);

        }
    }
}