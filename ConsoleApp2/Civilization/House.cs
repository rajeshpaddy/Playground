using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Civilization
{
    public class House : IHouse , IDisposable
    {
        private readonly INamesGenerator namesGenerator = new NamesGenerator();
        private bool disposed = false;
        private readonly List<IRoom> _listofRooms = new List<IRoom>();
        private readonly List<IGarage> _listofGarages = new List<IGarage>();
        private  int _numberOfRooms;
        private int _numberOfGarages;
        public IRoom GetRoom(Guid guid)
        {
            return _listofRooms.FirstOrDefault(room => room.ID == guid);
        }

        public IRoom GetRoom(string name)
        {
            return _listofRooms.FirstOrDefault(room => room.Name == name);
        }

        public List<IRoom> Rooms()
        {
            return _listofRooms;
        }

        public RoomType RoomType { get; set; }
        public string Name { get; set; }
        public int GetNumberOfWindows()
        {
            return _listofRooms.Sum(windows => windows.NumberOfWindows);
        }

        public int GetNumberOfDoors()
        {
            return _listofRooms.Sum(windows => windows.NumberOfDoors);
        }

        public string Address { get; set; }
        public float Value { get; set; }
        public Color ExteriorColor { get; set; }
        public float GetArea()
        {
            float area = 0;
            foreach (var room in _listofRooms)
            {
                area += room.Area;
            }

            return area;
        }

        public int GetNumberOfRooms()
        {
            return _numberOfRooms;
        }

        public int GetNumberOfGarages()
        {
            return _numberOfGarages;
        }

        public void AddRooms(IRoom room)
        {
            _listofRooms.Add(room);
            _numberOfRooms++;
        }

        public void AddRooms(int numberOfRooms)
        {
            for (int i = 0; i < numberOfRooms; i++)
            {
                AddRooms(new Room());
            }

            ;
        }


        public void AddGarages(IGarage garage)
        {
            _listofGarages.Add(garage);
            _numberOfGarages++;
            
        }

        public void AddGarages(int numberOfGarages)
        {
            for (int i = 0; i < numberOfGarages; i++)
            {
                AddGarages(new Garage());
            }
        }

        public override string ToString()
        {
            string _return="";
            _return= String.Format("*********************************************************************\n");
            _return += String.Format("The name of the house is {0} \n", Name);
            _return+= String.Format("The {0} has {1} rooms and {2} garage \n", Name,_numberOfRooms,_numberOfGarages);
            _return += String.Format("The {0} has {1} doors and {2} windows\n", Name, GetNumberOfDoors(), GetNumberOfWindows());
            _return += String.Format("The price of the house is {0} \n", Value.ToString("C"));
            _return += String.Format("The address of {0} is {1} \n", Name,Address);
            _return += String.Format("The area of the house is {0} sqft \n", GetArea());
            _return += String.Format("*********************************************************************");
            return _return;
        }

        public void Dispose()
        {
            Dispose(true);

        }

        private void Dispose(bool v)
        {
        
        }

        public House()
        {
            Name = namesGenerator.GetRandomName();

        }

 
    }
}