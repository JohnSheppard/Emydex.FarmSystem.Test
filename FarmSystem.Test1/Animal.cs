using System;

namespace FarmSystem.Test1
{
    /// <summary>
    /// Animal Base class 
    /// </summary>
    public class Animal
    {        
    
        public virtual void Talk()
        {
            //Console.WriteLine("This animal cannot talk.");
        }

        public virtual void Walk()
        {
            //Console.WriteLine("This animal cannot walk.");
        }

        public virtual void ProduceMilk()
        {
            //Console.WriteLine("This animal cannot produced milk.");
        }

        public virtual void Run()
        {
            //Console.WriteLine("This animal cannot run.");
        }

        // NOTE: There are a number of ways one could add a textual description to the class.
        // I chose the least code approach however one could introduce a property which is either set at the child class level or
        // is optionally assigned via the constructor if more flexible is desired.
        public string AnimalDescriptor => this.GetType().Name.ToString();
            
    }
}