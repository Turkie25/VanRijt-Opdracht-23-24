using VanRijtDataBase.Dtos.Event;

namespace VanRijtDataBase
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            //maps user to get user dto
            CreateMap<User, GetUserDto>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Login != null ? src.Login.Username : null));

            //maps posteventdto to event
            CreateMap<PostEventDto, Evenement>()
             .ForMember(dest => dest.Adres, opt => opt.MapFrom(src => new Adres
             {
                 Straat = src.Straat,
                 HuisNummer = src.HuisNummer,
                 PostCode = src.PostCode
             }))
             .ForMember(dest => dest.User, opt => opt.Ignore()); // Assuming User property is handled separately

            //maps posteventdto to adress
            CreateMap<PostEventDto, Adres>()
           .ForMember(dest => dest.Straat, opt => opt.MapFrom(src => src.Straat))
           .ForMember(dest => dest.HuisNummer, opt => opt.MapFrom(src => src.HuisNummer))
           .ForMember(dest => dest.PostCode, opt => opt.MapFrom(src => src.PostCode));
        }
    }
}
 