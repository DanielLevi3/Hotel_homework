using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    class RoomForTwo : Room
    {
        public RoomForTwo(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            _features = "TV,Minibar,Bathroom,Two beds that can be connected to one bed , little porch";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
