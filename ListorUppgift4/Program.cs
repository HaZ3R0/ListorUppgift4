using System;
using System.Collections.Generic;
namespace ListorUppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Du ska få skriva in alla dina sesnet löner när du är klar skriv bara 0");
            int löner = 1;

            do
            {
                löner = int.Parse(Console.ReadLine());
                if (löner != 0)
                {
                    list.Add(löner);
                }
            }while (löner != 0);
           
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }


            int medel = sum / list.Count;
            list.Sort();

            Console.WriteLine("Medelvärdet är " + medel);

            double medianvärde = 0;

            if (list.Count % 2 == 0)
            {
                int medelindex = list.Count / 2;
                medianvärde = (list[medelindex - 1] + list[medelindex]) / 2;
            }

            else
            {
                int medelindex = list.Count / 2;
                medianvärde = list[medelindex];
            }

            Console.WriteLine("medianvärdet är " + medianvärde);

        }
    }
}