namespace WebApplication2.Models
{
    public class SpaceObject
    {
        public Guid id { get; set; }
        public int star_system_id { get; set; }
        public bool is_center  { get; set; }
        public int type { get; set; }
        public int age { get; set; }
        public float mass { get; set; }
        public string diametr { get; set; }

    }
}
