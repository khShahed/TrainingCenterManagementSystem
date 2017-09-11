using System.Collections.Generic;
using System.Linq;
using TCMS.DAL;
using TCMS.Models;

namespace TCMS.BLL
{
    public class RoomManager
    {
        public List<Room> GetAll()
        {
            return new RoomGateway().GetAll();
        }
        public bool Save(Room room)
        {
            return new RoomGateway().Save(room) > 0;
        }
        public bool Update(Room room)
        {
            return new RoomGateway().Update(room) > 0;
        }
        public bool Delete(Room room)
        {
            return new RoomGateway().Delete(room) > 0;
        }
        public Room Search(int id)
        {
            return new RoomGateway().Search(id);
        }

        public bool IsRoomNoExist(string roomNo)
        {
            var rooms = GetAll();
            var room = rooms.FirstOrDefault(n => n.RoomNo.Equals(roomNo));
            return room != null;
        }
    }
}
