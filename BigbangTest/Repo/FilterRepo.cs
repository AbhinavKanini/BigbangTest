﻿using BigbangTest.Modules;


namespace BigbangTest.Repo
{
    public class FilterRepo : IFilter
    {
        private readonly MyworldDbcontext _dbContext;

        public FilterRepo(MyworldDbcontext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Hotel> GetFilteredHotels(string Place, decimal? minPrice, decimal? maxPrice)
        {
            var hotels = _dbContext.Set<Hotel>().AsQueryable();
            var rooms = _dbContext.Set<Room>().AsQueryable();

            if (!string.IsNullOrEmpty(Place))
                hotels = hotels.Where(h => h.HPlace.Contains(Place));

            if (minPrice != null)
                hotels = hotels.Where(h => h.HCost >= minPrice);

            if (maxPrice != null)
                hotels = hotels.Where(h => h.HCost <= maxPrice);

            return hotels.ToList();
        }

        public int Results(int id)
        {
            Hotel hotel = _dbContext.Hotel.FirstOrDefault(h => h.Id == id);


            int availableRoomsCount = _dbContext.Room.Count(r => r.Id == id && r.IsActive == true);

            return availableRoomsCount;

        }
    }
}