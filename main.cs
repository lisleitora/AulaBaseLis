using System;
using static Helpers;

class Program
{

    public static void Main(string[] args)
    {
        Write("Olá");
        string name = Read("Escreva seu nome");
        int age = ReadInt("Escreva sua idade");
        if (age >= 35)
        {
            Write("Ai meu deus, você é tãããoo velho!Que nojo...");
        }
        else
        {
            Write("'Bora lá cara");
        }
    }

}