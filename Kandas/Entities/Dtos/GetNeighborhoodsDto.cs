namespace Entities.Dtos
{
    public class GetNeighborhoodsDto
    {
        public int NeighborhoodId { get; set; }
        public string NeighborhoodName { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
    }
}
