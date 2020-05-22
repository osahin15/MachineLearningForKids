using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    public class TwitterTest
    {
        private string[] likes = {"iyi","çok iyi","mükemmel","inanılmaz","en iyi","güzel","başarılı" };
        private string[] dislikes = { "kötü", "berbat", "deli", "çok kötü", "en kötü", "çirkin", "başarısız", };

        public TwitterTest()
        {

        }
        
        public string[] Likes
        {
            get
            {
                return likes;
            }
            private set { }
        }
        public string[] Dislikes
        {
            get
            {
                return dislikes;
            }
            private set { }
        }
        public bool IsLike(string text,string[] arr,bool ret)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (text.Contains(arr[i]))
                {
                    return ret = true;
                }
            }
            return ret = false;
        }
        public bool IsLıkeForFlow(string text,List<string> arr,bool ret)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (text.Contains(arr[i]))
                {
                    return ret = true;
                }
            }
            return ret = false;
        }
    }
}
