namespace TravelApi.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Review  { get; set; }
    }
}