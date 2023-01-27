using AutoMapper;

namespace MyfirstWebAPI.Model.Profiles
{
    public class RegionProfile:Profile
    {
        public RegionProfile()
        {
            CreateMap<Model.Domain.Region, Model.DTO.Region>();
        }
        
    }
}
