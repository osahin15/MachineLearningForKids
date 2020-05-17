using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningForKids.JourneySchool
{
    public class Journeyschool<T>
    {



        private T Age;
        private T Distance;
        private T Friends;

        public Journeyschool(T age , T distance , T friends)
        {
            Age = age;
            Distance = distance;
            Friends = friends;
        }

        public T Ag
        {
            get { return Age;}
            set { Age = value; }
        }
        public T Dis
        {
            get { return Distance; }
            set { Distance = value; }
        }
        public T Fri
        {
            get { return Friends; }
            set { Friends = value; }
        }

        public void ResetJourneyschool()
        {
            Ag = default(T);
            Dis = default(T);
            Fri = default(T);
        }


    }
}
