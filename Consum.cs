using CsvHelper.Configuration.Attributes;

namespace M03UF5AC3
{
    public class Consum
    {
        [Index(0)]
        public int Any { get; set; }
        [Index(1)]
        public int CodiComarca { get; set; }
        [Index(2)]
        public string? Comarca { get; set; }
        [Index(3)]
        public int Poblacio { get; set; }
        [Index(4)]
        public int DomesticXarxa { get; set; }
        [Index(5)]
        public int ActivitatsEconomiques { get; set; }
        [Index(6)]
        public int Total { get; set; }
        [Index(7)]
        public double ConsumDomesticPerCapita { get; set; }
    }
}
