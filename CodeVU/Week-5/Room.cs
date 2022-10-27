using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5
{
    public class Room
    {
        private string _roomName;
        private string _roomSize;
        private int _roomLevel;


        public Room(string _roomName, string _roomSize, int _roomLevel)
        {
            this._roomName = _roomName;
            this._roomSize = _roomSize;
            this._roomLevel = _roomLevel;
        }

        public string RoomName
        {
            get { return _roomName; }
            set { _roomName = value; }
        }

        public string RoomSize
        {
            get { return _roomSize; }
            set { _roomSize = value; }
        }
        public int RoomLevel
        {
            get { return _roomLevel; }
            set { _roomLevel = value; }
        }


    }
}
