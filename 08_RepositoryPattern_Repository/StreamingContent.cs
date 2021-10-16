using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Repository
{
    public enum MaturityRating
    {
        G = 1,
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA,
        NR
    }
    public enum GenreType
    {
        Horror = 1,
        Thriller,
        Mockumentary,
        RomCom,
        Romance,
        Drama,
        Action,
        Comedy
    }
   
    public class StreamingContent
    {
        //object that we will create a collection of
        //get method = retrieving value of property
        //set method = giving value of the property
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        //user can NOT set this prop ONLY retrieve it
        public bool IsFamilyFriendly
        {
            get
            {
                //return true or false based upon a maturity rating
                //give my computer a maturity and it then needs to decide if it family family - conditional
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.NC_17:
                    case MaturityRating.NR:
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
                //another way
                //if((int)MaturityRating > 2)
                //{
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}
            }
        }
        //constructors - tell developers what they need to create an instance of that class/ object
        //default constructor - that you don't have give ANY value to create this object
        public StreamingContent()
        {
            Console.WriteLine("Streaming Content constructor");
        }
        //overloaded constructor - you DO have to give some value to create this object
        public StreamingContent(string title, string description, double starRating, MaturityRating maturityRating, GenreType genreType)
        {
            //property NAME = parameter NAME/value
            Title = title;
            Description = description;
            //0 = 5.5
            StarRating = starRating;
            MaturityRating = maturityRating;
            TypeOfGenre = genreType;
            //you can NOT do this
            //5.5 = 0
            //starRating = StarRating;
        }
    }
}
