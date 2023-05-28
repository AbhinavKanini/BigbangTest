using BigbangTest.Modules;
using Microsoft.EntityFrameworkCore;

namespace BigbangTest.Repo
{
    public class HotelRepo : IHotel
    {
        private readonly MyworldDbcontext _dbContext;

        public HotelRepo(MyworldDbcontext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddHotel(Hotel hotel)
        {
            _dbContext.Set<Hotel>().Add(hotel);
            _dbContext.SaveChanges();
        }

        public void DeleteHotel(int id)
        {
            var hotel = _dbContext.Set<Hotel>().Find(id);
            _dbContext.Set<Hotel>().Remove(hotel);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return _dbContext.Set<Hotel>().ToList();
        }

        public Hotel GetHotelById(int id)
        {
            return _dbContext.Set<Hotel>().Find(id);
        }

        public void UpdateHotel(Hotel hotel)
        {
            _dbContext.Entry(hotel).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}