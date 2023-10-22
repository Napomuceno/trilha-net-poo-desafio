using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Realizar os testes com as classes Nokia e Iphone
            Console.WriteLine("=====================================");
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "27998087-2873", modelo: "FE ultra model one", imei: "278912851256", memoria: 128);
            nokia.Ligar();
            nokia.InstalarAplicativo("Dio.me");
            Console.WriteLine("=====================================");

            Console.WriteLine("Smartphone iPhone:");
            Smartphone iphone = new Iphone(numero: "28988087-2873", modelo: "iphone 15", imei: "278912851257", memoria: 32);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("linkedin");
            Console.WriteLine("=====================================");

        }


    }

}



