using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Mapping

{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType, IndexVM>().ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumberOfDays));
        }
    }
}