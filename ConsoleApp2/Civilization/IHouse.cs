
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Reflection.Metadata;
using System.Text;

namespace Civilization
{
    public interface IHouse
    {
        IRoom GetRoom(Guid guid);
        IRoom GetRoom(string name);
        List<IRoom> Rooms();
        RoomType RoomType  { get; set; }
        string Name { get; set; }
        int GetNumberOfWindows();
        int GetNumberOfDoors();
        string Address { get; set; }
        float Value { get; set; }
        Color ExteriorColor { get; set; }
        float GetArea();
        int GetNumberOfRooms();
        int GetNumberOfGarages();
        void AddRooms(IRoom room);
        void AddRooms(int numberOfRooms);
        void AddGarages(IGarage garage);
        void AddGarages(int numberOfGarages);
        string ToString();
    }

    public enum RoomType
    {
        Bedroom=1,
        Den=2,
        Loft=3,
        Living=4,
        Dining=5,
        Family=6
    }
}

