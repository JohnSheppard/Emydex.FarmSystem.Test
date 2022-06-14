using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        private string _id;
        private int _noOfLegs = 4;        

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public override void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public override void ProduceMilk()
        {
            //Changed text as per Test3Object. Not sure if this is really just nitpicking :)
            //Console.WriteLine("Cow produced milk");
            Console.WriteLine("Cow was milked!");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}