using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    internal class RoomService
    {
        public override string ToString()
        {
            return base.ToString();
        }
        internal void CleanRoom(Room r)
        {
            Console.WriteLine($"{r.GetFeatures()} is clean");
        }
            internal void CleanRoom(RoomForTwo roomForTwo)
        {
            Console.WriteLine("TV,Minibar,Bathroom,Two beds that can be connected to one bed , little porch, all are clean now");
            roomForTwo.SetIsClean(true);
        }
        internal void CleanRoom(FamilyRoom familyRoom)
        {
            Console.WriteLine("TV, Minibar, LittleKitchen, DoubleMatress bed with 1 children bed, Bathub and one more bathroom all are clean now");
            familyRoom.SetIsClean(true);

        }
        internal void CleanRoom(Suite suite)
        {
            Console.WriteLine("TV,Minibar,Jacuzi,KingSizeBad,OceanView,BigPorch all is clean now");
            suite.SetIsClean(true);

        }
    }
}
