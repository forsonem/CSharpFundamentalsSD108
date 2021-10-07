using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using statements are there to reference other FOLDERS aka project/assemblies/namespaces

namespace _08_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        //new instance of the list class
        //new list object that contains streamcontent objects
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //REPO - holds my business logic
        //allowing transfer of info from my collection to my user interface
        //CRUD methods
        //Create
        //take in a streaming content object and add it to my list
        //refactor - where you cahnge code to either be better or to adjust for breaking changes
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            //Did my startingCount change?
            bool wasAdded = _contentDirectory.Count > startingCount ? true : false;
            return wasAdded;
            //return _contentDirectory.Count > startingCount;
        }
        //Read
        //give me every item in my collection
        public List<StreamingContent> GetAllContents()
        {
            return _contentDirectory;
        }
        //find the old streaming content by title
        //The Incredibles
        //the incredibles
        //ThE InCredIblEs
        public StreamingContent GetContentByTitle(string title)
        {
            //searching my collection for a title
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        //Update
        //need to update a streaming content object to have new values for it's properties
        //find the old streaming content object BY a unique identifier(title) in my list and then update it's properties
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            //returns null or streamingcontent object with value
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }





        
        //Delete
        //take in an existing streaming content object and delete from my list
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
