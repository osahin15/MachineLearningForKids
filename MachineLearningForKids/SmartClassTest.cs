using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    public class SmartClassTest
    {

        private string[] LampOn = { "light", "lamp", "see", "dark" };
        private string[] LampOff = { "bright", "darker", "off" };
        private string[] FanOn = { "fan", "air", "hot" };
        private string[] FanOff = { "cold", "breezy", "windy", "off" };

        public SmartClassTest()
        {

        }

        public string[] lampOn
        {
            get
            {
                return LampOn;
            }
            private set { }
        }

        public string[] lampOff
        {
            get
            {
                return LampOff;
            }
            private set { }
        }

        public string[] fanOn
        {
            get
            {
                return FanOn;
            }
            private set { }
        }

        public string[] fanOff
        {
            get
            {
                return FanOff;
            }
            private set { }
        }


        public bool FindWord(string text, string[] arr, bool retVal)
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
