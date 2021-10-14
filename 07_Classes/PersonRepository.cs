using _07_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    // 1. Create a class called PersonRepository.cs in your class library project from yesterday's lecture called 07_Classes.

    // 2. Create a list of Person objects that you can access throughout the entire class and solution.

    // 3. Create a method that adds a person object to that list.

    // 4. Create a method that can return the entire persons list.

    // 5. Create a method that can delete a specific person from that list by a person's name.

    // 6. Create a method that can update a specific person from that list.

    public class PersonRepository
    {
        private List<Person> _listOfPeople = new List<Person>();

        public bool AddPerson2(Person person)
        {
            int beforeCount = _listOfPeople.Count;
            _listOfPeople.Add(person);
            int afterCount = _listOfPeople.Count;
            if(afterCount == (beforeCount + 1))
            {
                return true;
            }
            return false;
        }

        public bool DeletePersonByFirstName(string name) //
        {
            
            foreach(Person p in _listOfPeople)
            {
                if(p.FirstName == name)
                {
                    _listOfPeople.Remove(p);
                    return true;
                }
            }
            return false;
        }


        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public void AddPerson(Person person)
        {

            _listOfPeople.Add(person);
        }

        public List<Person> ReturnListOfPeople()
        {
            return _listOfPeople;
        }


        public void RemovePersonByName(string firstName)
        {
            foreach (Person p in _listOfPeople)
            {
                if (p.FirstName == firstName)
                {
                    _listOfPeople.Remove(p);
                }

            }
        }

        public Person UpdatePerson(Person oldPerson, Person newPerson)
        {
            foreach (Person p in _listOfPeople)
            {
                if (p == oldPerson)
                {
                    p.FirstName = newPerson.FirstName;
                    p.LastName = newPerson.LastName;
                    p.DateOfBirth = newPerson.DateOfBirth;

                    return p;
                }
            }
            return null;
        }

    }
}