using BigbangTest.Modules;

namespace BigbangTest.Repo
{
    public interface IRoom
    {
        Room GetRoomById(int id);
        IEnumerable<Room> GetAllRoom();
        void AddRoom(Room Room);
        void UpdateRoom(Room Room, int id);
        void DeleteRoom(int id);
    }
}