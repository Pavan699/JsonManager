using System;

namespace JsonDataManagaer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JSON Inventory Managment");
            JsonManager jmanager = new JsonManager();
            jmanager.calculate();
        }
    }
}
