using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            DriveInfo[] disks = DriveInfo.GetDrives();
            foreach(DriveInfo disk in disks)
            {
                Console.WriteLine("Name -") ; Console.WriteLine(disk.Name);
                Console.WriteLine("Fyle system -") ; Console.WriteLine(disk.DriveFormat);
                Console.WriteLine("Type -") ; Console.WriteLine(disk.DriveType);
                Console.WriteLine("Total size -") ; Console.WriteLine(disk.TotalSize);
                Console.WriteLine("Total free space -") ; Console.WriteLine(disk.TotalFreeSpace);
            }
        }
    }
}
