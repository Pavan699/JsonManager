using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace JsonDataManagaer
{
    public class User//class for get(),set() method 
    {
        public string name { get; set; }
        public double weigth { get; set; }
        public double price { get; set; }
    }  
    
    public class JsonManager
    {
        //Lists to store the data(created Objects)...
        List<User> writeuser = new List<User>();
        
        public void calculate()
        {
            User us1 = new User()//data assining
            {
                name = "Rice",
                weigth = 15.5,
                price = 40.50
            };
            User us2 = new User()
            {
                name = "Pulses",
                weigth = 30,
                price = 15.50
            };
            User us3 = new User()
            {
                name = "Wheats",
                weigth = 59.04,
                price = 54
            };
            writeuser.Add(us1);//data adding into list
            writeuser.Add(us2);
            writeuser.Add(us3);            
            //Object Conversion into string(Serialization)
            string write = JsonConvert.SerializeObject(writeuser);
            File.WriteAllText(@"D:\VS .net\JsonDataManagaer\JsonDataManagaer\Details.json", write);//fileCreation and Printing the string format data
            //printing the data from Object
            foreach (var i in writeuser)
            {
                Console.WriteLine(i.name + "    " + i.weigth + "    " + i.price);
            }          
        }
    }
}
