namespace DorogaUa.Domain.Models.Entities
{
    class HotelEntity
    {           
        public string Name { get; set; }

        public string NumberPhone { get; set; }

        public string CoordinateN { get; set; }

        public string CoordinateE { get; set; }

        public double Rating { get; set; }

        public string Link { get; set; }

        public int Price { get; set; }

        // Need Add Reviews and Address
    }
}