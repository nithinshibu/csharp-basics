using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.MyExampleNamespace
{
    /*Encapsulation (OOPS concept) is about bundling the data (fields) and the methods (functions) that operate on the data into a single unit (class). It also involves restricting access to some of the object's components.*/
    class PersonClass
    {
        private int _age;  

       
        public int Age
        {
            get
            {
                
                return _age;
            }
            set
            {
                
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                }
                else if (value > 120)
                {
                    Console.WriteLine("Age cannot be greater than 120.");
                }
                else
                {
                   
                    _age = value;
                }
            }
        }

        // Other properties
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
