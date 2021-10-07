using _08_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client wants a console app for her users that allow them to store a collection of streaming content.
            //List<string>, List<StreamingContent>
            //StreamingContent.cs
            //point of app is for the users to interact with their collection so that they can keep an up to date collection of their fav streaming content at that time
            //interact with my users inside my console app - User Interface - ProgramUI.cs
            //users interact with collection - business logic - Repository Pattern - Repo.cs > CRUD methods

            //Single Responsiblity Principle
            //console app project - be the application/user interface
            //Program.cs
            //ProgramUI.cs

            // Class Library - users interact with collection - business logic
            // Repo.cs
            // StreamingContent.cs
        }
    }
}
