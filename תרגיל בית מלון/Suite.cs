using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    class Suite : Room
    {
        public Suite(int roomNumber, float price ) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            _features="TV,Minibar,Jacuzi,KingSizeBad,OceanView,BigPorch";
        }

        protected override void SetPrice()
        {
            this._price = base._price +100;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
