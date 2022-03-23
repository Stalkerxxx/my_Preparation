using System;

namespace Task08_Structurs_
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new();
            computer1.BatteryLife = 180;
            computer1.InstalledOs = "Windows";
        }
    }

    public struct Computer
    {
        public string Processor{ get; set; }
        public int BatteryLife { get; set; }
        public double Weigth { get; set; }
        public byte NumberOfCores { get; set; }
        public string InstalledOs { get; set; }
    }

}
