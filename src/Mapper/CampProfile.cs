using AutoMapper;
using CoreCodeCamp.Data;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Mapper
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>();
        }
    }
}
