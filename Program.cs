using System;

namespace Mod4_1302204026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> sdb = new SimpleDataBase<int>();

            sdb.AddNewData(13); sdb.AddNewData(02); sdb.AddNewData(20);
            sdb.PrintAllData();
        }
    }
}