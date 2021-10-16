using _09_Inheritance_ClassLibrary;
using _08_RepositoryPattern_Repository;
using _09_StreamingContentInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InheritanceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat1 = new Cat();
            //cat1.Move();

            //Animal animal1 = new Animal();
            //animal1.Move();

            //Lion lion1 = new Lion();
            //lion1.Move();
            //lion1.MakeSounds();


            //Console.ReadKey();
            
            Movie movie1 = new Movie();
            Show show1 = new Show();

            List<StreamingContent> listStreamingContent = new List<StreamingContent>();

            listStreamingContent.Add(movie1);
            listStreamingContent.Add(show1);

            List<Movie> movies = new List<Movie>();

            StreamingContent stContent = new StreamingContent();

            listStreamingContent.Add(stContent);


            Movie movie2 = new Movie("Titanic", "people drowned", 4.00, MaturityRating.PG, GenreType.Comedy, 204.00);



           

            
        }
    }
}
