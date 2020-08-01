using System;

namespace Room
{
     static class Reception
    {
        private const int _numberOfRooms = 100;
        private static int _numberOfGuests=0;
        private static Room[] _rooms;
         
       static Reception()
        {
            _rooms = new Room[_numberOfRooms];
            for (int i = 0; i < _numberOfRooms-1; i++)
            {
                if(i % 3 == 0)
                { 
                    _rooms[i] = new RoomForTwo(i, 50);
                }
                else if(i % 2 == 0)
                {
                    _rooms[i] = new FamilyRoom(i, 100);
                }
                else
                {
                    _rooms[i] = new Suite(i, 200);
                }
               
            }
        }
        private static RoomService _roomService = new RoomService();
        public static void CheckIn(Guest g)
        {
           for(int i = 1; _rooms.Length>i;i++)
            {
                if(IsRoomFree(_rooms[i]))
                {
                    _rooms[i].SetGuest(g);
                    if (!_rooms[i].IsClean())
                    {
                        SendRoomService(_rooms[i]);
                    }
                    _numberOfGuests++;
                    Console.WriteLine($"Guest{g} has checkin to room {i}");
                    return;
                }
            }
        }
        public static void CheckOut(Room r)
        {
            r.SetGuest(null);
            _numberOfGuests--;
            Console.WriteLine($"Room {r} is empty now");
        }
        public static bool IsRoomFree(Room r)
        {
            return r.GetGuest() == null;
        }
        public static void SendRoomService(Room r)
        {
            _roomService.CleanRoom(r);
        }


    }
}
