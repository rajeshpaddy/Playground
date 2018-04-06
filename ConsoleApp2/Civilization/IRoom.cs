using System;

namespace Civilization
{
    public interface IRoom
    {
        
        string Name { get; }
        Guid ID { get; }
        float Area { get; set; }
        FloorType FloorType  { get; set; }
        int NumberOfWindows { get; set; }
        int NumberOfDoors { get; set; }
        void AddWindows(IWindow window);
        void AddDoors(IDoor door);
        void AddItems(IItems items);
        string ToString();
    }

    public enum FloorType
    {
        Carpet=1,
        Hardwood =2
    }
}