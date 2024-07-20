using GCDNLCMCounting;

namespace GCDCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GCDorHCFCalculator.GCDorHCF(12,15));
            int gcd=GCDorHCFCalculator.GCDorHCF(12, 15);
            Console.WriteLine(LCMCalculator.LCM(12, 15, gcd));
        }
    }
}
