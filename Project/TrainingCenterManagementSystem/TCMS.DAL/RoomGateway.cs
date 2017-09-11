using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCMS.Models;

namespace TCMS.DAL
{
    public class RoomGateway
    {
        public List<Room> GetAll()
        {
            using (var context = new TCMSContext())
            {
                return context.Rooms.ToList();
            }
        }
        public int Save(Room room)
        {
            using (var context = new TCMSContext())
            {
                context.Rooms.Add(room);
                return context.SaveChanges();
            }
        }
        public int Update(Room room)
        {
            using (var context = new TCMSContext())
            {
                context.Rooms.Attach(room);
                context.Entry(room).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
        public int Delete(Room room)
        {
            using (var context = new TCMSContext())
            {
                context.Rooms.Attach(room);
                context.Rooms.Remove(room);
                return context.SaveChanges();
            }
        }
        public Room Search(int id)
        {
            using (var context = new TCMSContext())
            {
                return context.Rooms.Find(id);
            }
        }
    }
}
