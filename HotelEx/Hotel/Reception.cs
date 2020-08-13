using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public static class Reception
    {
        #region Properties
        const int NUMBER_OF_ROOMS = 3;
        static int numberOfGuests = 0;
        static Room[] rooms = new Room[NUMBER_OF_ROOMS];
        public static Room[] Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        static RoomService roomService = new RoomService();
        #endregion

        #region Methods
        static public Room CheckIn(Guest guest)
        {
            foreach(var room in rooms)
            {
                if(room != null)
                {
                    room.SetGuest(guest);
                    ++numberOfGuests;
                    return room;
                }
            }

            return null;
        }
        static public void CheckOut(Room room)
        {
            if(room.GetGuest() != null)
            {
                room.SetGuest(null);
                --numberOfGuests;
            }
        }
        public static bool IsRoomFree(Room room)
        {
            if(room.GetGuest() != null)
            {
                return false;
            }

            return true;
        }
        static void SendRoomService(Room room)
        {
            if (room is FamilyRoom)
            {
                roomService.CleanRoom((FamilyRoom)room);
            }
            else if (room is RoomForTwo)
            {
                roomService.CleanRoom((RoomForTwo)room);
            }
            else if (room is Suite)
            {
                roomService.CleanRoom((Suite)room);
            }
        }
        #endregion


    }
}
