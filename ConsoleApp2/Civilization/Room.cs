using System;
using System.ComponentModel;
using System.Text;

namespace Civilization
{
    public class Room :IRoom
    {
        NamesGenerator namesGenerator = new NamesGenerator();
        public Room()
        {
            NumberOfDoors = 1;
            NumberOfWindows = 1;
            Area = 0;
            ID=Guid.NewGuid();
            Name = namesGenerator.GetRandomName();
        }

        public Room(float area,FloorType floortype,int numberofwindows,int numberofdoors)
        {
            ID=new Guid();
            Area = area;
            FloorType = floortype;
            NumberOfDoors = numberofdoors;
            NumberOfWindows = numberofwindows;
            Name = namesGenerator.GetRandomName();
        }


        
        public string Name { get; }
        public Guid ID { get; }
        public float Area { get; set; }
        public FloorType FloorType { get; set; }
        public int NumberOfWindows { get; set; }
        public int NumberOfDoors { get; set; }
        public void AddWindows(IWindow window)
        {
            throw new System.NotImplementedException();
        }

        public void AddDoors(IDoor door)
        {
            throw new System.NotImplementedException();
        }

        public void AddItems(IItems items)
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            string _return = "";
            _return += String.Format("The name of the room is {0} \n", Name);
            _return += String.Format("The room {0} has {1} window(s) and {2} door(s) \n", Name, NumberOfWindows,NumberOfDoors);
            _return += String.Format("The area of the room is {0} sqft \n", Area);
            
            
            return _return;
        }
    }
}