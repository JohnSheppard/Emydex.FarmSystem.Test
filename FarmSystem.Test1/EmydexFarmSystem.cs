using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private Queue<Animal> AnimalQueue { get; set; }
        public event EventHandler FarmEmpty; 
        
        //CONSTRUCTOR
        public EmydexFarmSystem()
        {
            AnimalQueue = new Queue<Animal>();
        }

        //TEST 1
        public void Enter(Animal animal)
        {
            
            //TODO: Hold all the animals so it is available for future activities            
            AnimalQueue.Enqueue(animal);

            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Console.WriteLine("Animal has entered the Emydex farm");
            Console.WriteLine(animal.AnimalDescriptor + " has entered the Emydex farm");
            
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            //Console.WriteLine("There are no animals in the farm");

            //Note: The Test2Objective did not specify that this should be outputted, however I left it here with an error check as the output was in the original code.
            if (AnimalQueue.Count == 0) Console.WriteLine("There are no animals in the farm");

            foreach (var a in AnimalQueue)            
                a.Talk();
            
        }

        //TEST 3
        public void MilkAnimals()
        {
            //TODO:
            //Console.WriteLine("Cannot identify the farm animals which can be milked");

            foreach (var a in AnimalQueue)
                a.ProduceMilk();
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            //Console.WriteLine("There are still animals in the farm, farm is not free");            
            while (AnimalQueue.Count > 0)
                Console.WriteLine(AnimalQueue.Dequeue().AnimalDescriptor + " has left the farm");

            //TODO raise FarmEmpty Event            
            if (FarmEmpty != null)
                FarmEmpty.Invoke(this, EventArgs.Empty);
            
            //We could also do it using the null conditional operator as below;
            //https://stackoverflow.com/questions/34298411/question-mark-syntax-on-method-call
            //FarmEmpty?.Invoke(this,EventArgs.Empty);         
        }

    }
}