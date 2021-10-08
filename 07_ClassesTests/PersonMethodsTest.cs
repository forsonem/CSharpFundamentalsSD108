using _07_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_ClassesTests
{
    [TestClass]
    public class PersonMethodsTest
    {
        [TestMethod]
        public void Test_AddPerson()
        {

            //AAA

            //ARRANGE -  We are setting up the data required to test the method. So the question we need to ask ourselves is what does this method require in order to run. Does the method take any arguments?


            PersonRepository _repo = new PersonRepository();
            Person person = new Person();

            //ACT - After we have set up all the required data to call and pass into our method. we now have to call the method and save what the method returs to  avarible if it returns anything.


            List<Person> localList = _repo.ReturnListOfPeople();
            int count = localList.Count;

            _repo.AddPerson(person);

            List<Person> updatedLocalList = _repo.ReturnListOfPeople();
            int newCount = updatedLocalList.Count;

            bool result = newCount == (count + 1) ? true : false;



            //ASSERT - After we have run our method, we need to compare what the method returned or the result of the method running to the expected using Assert Methods.

            Assert.IsTrue(result);

        }


    }
}
