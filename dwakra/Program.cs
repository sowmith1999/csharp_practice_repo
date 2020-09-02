using System;

namespace dwakra
{
    class Program
    {
        static void Main(string[] args)
        {
            double total=750000;
            var monthly=25000;
            var interest=0.75;
            var noOfMonths=0;
            do
            {
                total=total+interest*(total/100);
                noOfMonths+=1;
                total=total-25000;
                System.Console.WriteLine(noOfMonths+" "+total);
            } while (total>25000);
            System.Console.WriteLine(noOfMonths);
        }
    }
}
