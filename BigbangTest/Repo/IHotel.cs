using BigbangTest.Modules;


namespace BigbangTest.Repo
{
    public interface IHotel
    {
        Hotel GetHotelById(int id);
        IEnumerable<Hotel> GetAllHotels();
        void AddHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}