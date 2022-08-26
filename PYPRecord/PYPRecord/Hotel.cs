using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYPRecord
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Room[] _rooms = new Room[0];

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length+1);
            _rooms[_rooms.Length-1] = room;
        }



        public void MakeReservation(int? id)
        {
            if(id == null)
            {
                throw new NullReferenceException("Null id ola bilmez");
            }
            Room room = Array.Find(_rooms, x => x.Id == id);

            if(room == null) throw new NullReferenceException("bele id'li Otaq yoxdur");

            if (room.IsAvailable)
            {
                room.IsAvailable = false;
            }
            else
            {
                throw new NotAvailableException("Otaq doludur");
            }

        }

        public Room[] GetRooms()
        {
            return _rooms;
        }
    }
}
