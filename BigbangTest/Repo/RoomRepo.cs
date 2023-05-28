using BigbangTest.Modules;
using Microsoft.EntityFrameworkCore;

namespace BigbangTest.Repo
{
    public class RoomRepo : IRoom
    {
        private readonly MyworldDbcontext _dbContext;

        public RoomRepo(MyworldDbcontext dbContext)
        {
            _dbContext = dbContext;
        }


        public Room GetRoomById(int id)
        {
            var userobj = _dbContext.Room.Find(id);
            return userobj;
        }

        public IEnumerable<Room> GetAllRoom()
        {
            return _dbContext.Room.ToList();
        }

        public void AddRoom(Room rooms)
        {
            _dbContext.Room.Add(rooms);
            _dbContext.SaveChanges();
        }

        public void UpdateRoom(Room rooms, int id)
        {
            var ress = _dbContext.Room.Find(id);
            ress.IsActive = rooms.IsActive;
            _dbContext.Room.Update(ress);
            _dbContext.SaveChanges();
        }

        public void DeleteRoom(int id)
        {
            var Rooms = _dbContext.Room.Find(id);
            _dbContext.Room.Remove(Rooms);
            _dbContext.SaveChanges();
        }
    }
}