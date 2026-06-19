namespace NZWalks.API.Model.Domain
{
    public class Walks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageURL { get; set; }
        public Guid RegionId { get; set; }
        public Guid DifficultyId { get; set; }

        //Navigation property
        public Difficulty Difficulty { get; set; }
        public Regions Regions { get; set; }

    }
}
