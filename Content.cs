using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class Content
    {
        public int ContentID { get; set; }
        public string ContentType { get; set; } // Video/Photo
        public string ContentURL { get; set; }
        public string Description { get; set; }

        public List<Content> ViewContent()
        {
            // Logic to view content
            return new List<Content>();
        }

        public void AddContent(string contentType, string contentURL, string description)
        {
            ContentType = contentType;
            ContentURL = contentURL;
            Description = description;
        }

        public void DeleteContent(int contentID)
        {
            // Logic to delete content
        }
    }

}
