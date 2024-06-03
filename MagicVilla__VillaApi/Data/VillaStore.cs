using MagicVilla__VillaApi.Models.Dto;

namespace MagicVilla__VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {

                new VillaDTO{Id = 1, Name = "Pool View", Sqft = 300, Occupancy=12 },
                new VillaDTO{Id = 2, Name = "Beach View", Sqft = 600, Occupancy=2 }
            };
    }
}
