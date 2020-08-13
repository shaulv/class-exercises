using Clients;
using Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reception.Rooms[0] = new FamilyRoom(1, 0);
            Reception.Rooms[1] = new RoomForTwo(2, 0);
            Reception.Rooms[1] = new Suite(3, 0);
            Guest shaul = new Guest(1, "shaul");


            Reception.CheckIn(shaul);

        }
    }
}
