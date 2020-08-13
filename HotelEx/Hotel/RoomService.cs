using System;

namespace Hotel
{
    internal class RoomService
    {
        internal void CleanRoom(RoomForTwo room)
        {
            room.SetIsClean = true;
            Console.WriteLine($"{room.GetFeatures()} was cleaned!!");
        }
        internal void CleanRoom(FamilyRoom room)
        {
            room.SetIsClean = true;
            Console.WriteLine($"{room.GetFeatures()} was cleaned!!");
        }
        internal void CleanRoom(Suite room)
        {
            room.SetIsClean = true;
            Console.WriteLine($"{room.GetFeatures()} was cleaned!!");
        }
    }
}