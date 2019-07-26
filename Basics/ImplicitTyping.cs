using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
    public class Bird
    {
        public Bird(string name, string color, int sightings)
        {
            Name = name;
            Color = color;
            Sightings = sightings;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Color: {1}, Sightings: {2}\n", Name, Color, Sightings);
        }
    }

    public static class BirdRepository
    {
        public static List<Bird> LoadBirds()
        {
            return new List<Bird>
            {
                new Bird ( "Cardinal", "Red", 3 ),
                new Bird ( "Dove", "White", 2 ),
                new Bird ( "Robin", "Red", 5 ),
                new Bird ( "Canary", "Yellow", 0 ),
                new Bird ( "Blue Jay", "Blue", 1 )
            };
        }
    }
}


// Implicit Typing

var canary = new Bird {Name="Canary", Color="Yellow", Sightings = 99};                              
birds.Add(canary);                                                                                  
birds;
/*
{ Name: Cardinal, Color: Red, Sightings: 3                                                                  
, Name: Dove, Color: White, Sightings: 2                                                                    
, Name: Robin, Color: Red, Sightings: 5                                                                     
, Name: Blue Jay, Color: Blue, Sightings: 1                                                                 
, Name: Canary, Color: Yellow, Sightings: 99                                                                
 }
*/

foreach(var bird in birds)                                                                          
{                                                                                                   
    Console.WriteLine(bird.Name);                                                                   
}

/*
Cardinal                                                                                                    
Dove                                                                                                        
Robin                                                                                                       
Blue Jay                                                                                                    
Canary
*/



// LINQ
from b in birds                                                                                     
where b.Color == "Red"                                                                              
select b;   
/*
{ Name: Cardinal, Color: Red, Sightings: 3                                                                  
, Name: Robin, Color: Red, Sightings: 5                                                                     
 }  
 */