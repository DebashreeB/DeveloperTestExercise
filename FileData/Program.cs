using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDetails flD = new FileDetails();
            do
            {
                string s1;

                s1 = Console.ReadLine().ToString().Trim();

                if (s1.Equals("-v") || s1.Equals("--v") || s1.Equals("/v") || s1.Equals("--version"))
                {
                    string strVer = flD.Version("/ThirdPartyTools/FileDates.cs");
                    Console.WriteLine(strVer);
                }
                else if (s1.Equals("-s") || s1.Equals("--s") || s1.Equals("/s") || s1.Equals("--size"))
                {
                    int Size = flD.Size("/ThirdPartyTools/FileDates.cs");
                    Console.WriteLine(Size);
                }
                else
                {
                    Console.WriteLine("Incorrect response");

                }
                //System.Threading.Thread.Sleep(30000);

                //Console.ReadLine();
            } while (!Console.ReadLine().Equals("exit"));
        }
    }
}
