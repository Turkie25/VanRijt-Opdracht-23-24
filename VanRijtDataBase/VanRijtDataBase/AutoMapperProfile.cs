namespace VanRijtDataBase
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, GetUserDto>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Login != null ? src.Login.Username : null));
        }
    }
}
