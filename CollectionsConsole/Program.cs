using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsConsole
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           

            //Dictionary

            Dictionary<int, Employee> _employeeDictionary = new Dictionary<int, Employee>();

            Employee employee1 = new Employee(1, "James", 75000);
            Employee employee2 = new Employee(2, "Matt", 45000);
            Employee employee3 = new Employee(3, "Todd", 150000);

            _employeeDictionary.Add(employee1.ID, employee1);
            _employeeDictionary.Add(employee2.ID, employee2);
            _employeeDictionary.Add(employee3.ID, employee3);


            


            Employee isEmployee2 = _employeeDictionary[2];
            Console.WriteLine(isEmployee2.Name);
            Console.ReadKey();


            foreach(KeyValuePair<int, Employee> kvp in _employeeDictionary)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", emp.ID, emp.Name, emp.Salary);
                Console.WriteLine("--------------------------------------------------------------");
            }
            Console.ReadKey();

            Employee employeeError = new Employee(1, "John", 900000);


            if (_employeeDictionary.ContainsKey(employeeError.ID))
            {
                //Console.WriteLine("Dictionary already contains key");
            }
            else
            {
                _employeeDictionary.Add(employeeError.ID, employeeError);
            }



            Employee emp2;
            if(_employeeDictionary.TryGetValue(100, out emp2))
            {
                Console.WriteLine(emp2.Name);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            Console.ReadKey();


            _employeeDictionary.Remove(1);

            _employeeDictionary.Clear();

            int count = _employeeDictionary.Count(kvp => kvp.Value.Salary > 100000);
            Console.WriteLine(count);
            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------


            Queue<Employee> _employeeQueue = new Queue<Employee>();

            Employee employee4 = new Employee(1, "James", 75000);
            Employee employee5 = new Employee(2, "Matt", 45000);
            Employee employee6 = new Employee(3, "Todd", 150000);

            //Adding to a queue

            _employeeQueue.Enqueue(employee4);
            _employeeQueue.Enqueue(employee5);
            _employeeQueue.Enqueue(employee6);

            //remove from our queue

           Employee emp3 =  _employeeQueue.Dequeue();
           Console.WriteLine(emp3.Name); //Prints James to the console
           Console.ReadKey();

            bool isEmp4 = _employeeQueue.Contains(employee4);
            Console.WriteLine(isEmp4);// prints false to console

            foreach(Employee emp in _employeeQueue)
            {
                _employeeQueue.Dequeue();
            }


            //------------------------------------------------------------------------------------------------------------

            Employee employee7 = new Employee(1, "James", 75000);
            Employee employee8 = new Employee(2, "Matt", 45000);
            Employee employee9 = new Employee(3, "Todd", 150000);

            Stack<Employee> _employeeStack = new Stack<Employee>();

            _employeeStack.Push(employee7);
            _employeeStack.Push(employee8);
            _employeeStack.Push(employee9);


            Employee topOfStack = _employeeStack.Pop();
            Console.WriteLine(topOfStack.Name);//prints Todd
            Console.ReadKey();


            Employee emp10 = _employeeStack.Peek();
            Console.WriteLine(emp10.Name);// prints Todd;

























            //Queues
            //Stack
            //Hashset
        }
    }
}
