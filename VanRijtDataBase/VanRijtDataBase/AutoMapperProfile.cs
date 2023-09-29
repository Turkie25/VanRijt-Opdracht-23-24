using VanRijtDataBase.Dtos.Event;

namespace VanRijtDataBase
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, GetUserDto>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Login != null ? src.Login.Username : null));

            CreateMap<PostEventDto, Evenement>()
             .ForMember(dest => dest.Adres, opt => opt.MapFrom(src => new Adres
             {
                 Straat = src.Straat,
                 HuisNummer = src.HuisNummer,
                 PostCode = src.PostCode
             }))
             .ForMember(dest => dest.User, opt => opt.Ignore()); // Assuming User property is handled separately
        }
    }
}
