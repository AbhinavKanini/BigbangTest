using BigbangTest.Modules;

namespace BigbangTest.Repo
{
    public interface IFilter
    {
        IEnumerable<Hotel> GetFilteredHotels(string? Place, decimal? minPrice, decimal? maxPrice);
        int Results(int id);
    }
}