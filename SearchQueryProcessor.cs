using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersAdvisor
{
    public class SearchQueryProcessor
    {
        public static List<string> MakeTags(string searchQuery)
        {
            List<string> tags;
            tags = searchQuery.ToLower().Split(' ').ToList();
            foreach (string tag in tags)
            {
                tag.Trim();
            }
            tags.RemoveAll(tag => tag == "");
            return tags;
        }
    }
}
