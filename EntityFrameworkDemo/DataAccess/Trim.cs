namespace EntityFrameworkDemo.DataAccess
{
    public class Trim
    {
        public long TrimId { get; set; }
        public double EngineDisplacement { get; set; }
        public string EngineName { get; set; }
        public Transmission Transmission { get; set; }
        public bool HasAc { get; set; }
        public bool HasAbs { get; set; }
        public bool HasElectricMirrorControl { get; set; }

        public Model Model { get; set; }
        public long ModelId { get; set; }
    }
}