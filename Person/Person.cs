using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        private string name;
        public string  Name
        {
             get
             {
               
                return " " ;
             }
             set
             {
                if (value.Length>=5)
                {
                    name = value;
                    Console.WriteLine("set is okey");
                    return;
                }
                Console.WriteLine("more length name add");
             }
        }
       



    } 
}
