namespace DorogaUa.Domain.Models.Entities
{
    class AttractionEntity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string NumberPhone { get; set; }

        public string CoordinateN { get; set; }

        public string CoordinateE { get; set; }

        public double Rating { get; set; }

        // Need Add Reviews and Address
    }
}
