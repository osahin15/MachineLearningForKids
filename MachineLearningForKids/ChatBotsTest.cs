using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    public class ChatBotsTest
    {

        private string[] testFood = {
            "What sort of foods do owls eat", "What do owls eat", "what do owls like to eat", "foods", "food", "eat"
        };
        private string[] testCountries = {
            "Where do owls live", "What areas of the world are owls found","What countries have owls","countries","where","areas"
        };
        private string[] testLifeSpan = {
            "How long do you live for", "How old can owls get", "How long can an owl live", "old", "long","How old","How long"
        };
        private string[] testSpecies = {
            "What are the main species of owl", "What species of owls are there", "What are the different breeds of owls"
        };
        private string[] testSize = {
            "How big are owls", "What size are you", "How big can owls get", "How tall are you", "How long are you", "How big do owls grow to","size","big","How big","How tall"
        };

        public ChatBotsTest()
        {

        }

        public string[] TestFood
        {
            get => testFood;
            private set { }
        }

        public string[] TestCountries
        {
            get => testCountries;
            private set { }
        }

        public string[] TestLifeSpan
        {
            get => testLifeSpan;
            private set { }
        }

        public string[] TestSpecies
        {
            get => testSpecies;
            private set { }
        }

        public string[] TestSize
        {
            get => testSize;
            private set { }
        }

        public bool Find(string text,string[] arr,bool retVal)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (text.Contains(arr[i]))
                {
                    return retVal = true;
                }
            }
            return retVal = false;
        }
    }
}
