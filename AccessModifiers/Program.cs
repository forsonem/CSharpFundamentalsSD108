using _07_ClassesNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Access
    {
        public string _age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Access accessOne = new Access();
            accessOne._age = "34";

            int.Parse(accessOne._age);

            Person person = new Person();

        }
        
    }
    

}
