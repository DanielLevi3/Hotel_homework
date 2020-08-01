using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    class FamilyRoom : Room
    {
        public FamilyRoom(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            _features="TV,Minibar,LittleKitchen,DoubleMatress bed with 1 children bed,Bathub and one more bathroom";
        }

        protected override void SetPrice()
        {
            this._price = base._price + 50;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
