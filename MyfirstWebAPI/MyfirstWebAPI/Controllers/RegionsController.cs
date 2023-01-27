using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyfirstWebAPI.Model.Domain;

using MyfirstWebAPI.Repository;
using System.Linq;
using System.Runtime.InteropServices;

namespace MyfirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        //private readonly IRegionRepositoryAsync regionRepositoryAsync;
        private readonly IMapper mapper;
        public RegionsController(IRegionRepository regionRepository,IMapper mapper )
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
            
        }
        [HttpGet]
        public async Task<IActionResult> GetALLRegionsAsync()
        {
            var regions = await regionRepository.GetAllAsync();
            var regionsDTO = new List<Model.DTO.Region>();
            regionsDTO = mapper.Map<List<Model.DTO.Region>>(regions);
            return Ok(regionsDTO);

        }

        //[HttpGet]
        //public IActionResult GetALLRegions()
        //{
        //    var regions = regionRepository.GetAll();

        //    //return DTO regions
        //    //var regionsDTO = new List<Model.DTO.Region>();

        //    //regions.ToList().ForEach(region =>
        //    //{
        //    //    var regionDTO = new Model.DTO.Region();
        //    //    {
        //    //        regionDTO.Id = region.Id;
        //    //        regionDTO.Code = region.Code;
        //    //        regionDTO.Name = region.Name;
        //    //        regionDTO.Area = region.Area;
        //    //        regionDTO.Lat = region.Lat;
        //    //        regionDTO.long1 = region.long1;
        //    //        regionDTO.Population = region.Population;
        //    //    };
        //    //    regionsDTO.Add(regionDTO);
        //    //});
        //    //return Ok(regions);
        //    var regionsDTO = new List<Model.DTO.Region>();
        //    regionsDTO = mapper.Map<List<Model.DTO.Region>>(regions);
        //    return Ok(regionsDTO);

        //}

    }

}
