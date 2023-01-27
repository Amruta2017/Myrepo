using MyfirstWebAPI.Model.Domain;

namespace MyfirstWebAPI.Model.DTO
{
    public class Region
    {
    
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double long1 { get; set; }
        public long Population { get; set; }

        

    }
}
