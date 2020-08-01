using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    abstract class Room
    {
        protected int _roomNumber;
        protected float _price;
        protected Guest _guest;
        protected bool _isClean;
        protected string _features;
        internal Room(int roomNumber,float price)
        {
            
            this._price = price;
            this._roomNumber = roomNumber;
            SetPrice();
            SetFeatures();
        }
        internal void SetGuest(Guest g)
        {
            this._guest = g;
        }
        protected virtual void SetPrice()
        {
            if (DateTime.Now.Minute % 2 == 0)
                this._price =_price + 50;
            else
                this._price =_price + 100;
        }
        protected abstract void SetFeatures();
        public int GetRoomNumber()
        {
            return _roomNumber;
        }
        public float GetPrice()
        {
            return this._price;
        }
        public Guest GetGuest()
        {
            return _guest;
        }
        public int GetRoomNumber(int roomnumber)
        {
            return this._roomNumber = roomnumber;
        }
        public bool IsClean()
        {
            return _isClean;
        }
        public void SetIsClean (bool isclean)
        {
            this._isClean = isclean;
        }
        public string GetFeatures()
        {
            return _features;
        }
        public override string ToString()
        {
            return $"[{base.ToString()}]:  RoomNumber:{_roomNumber} ,Price :{_price},IsClean: { IsClean()} GetFeatures: {GetFeatures()} ";
        }
    }
}
