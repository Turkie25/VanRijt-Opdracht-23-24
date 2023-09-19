namespace VanRijtDataBase
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        { 
            CreateMap<User,GetUserResponseDto>();
        
        }
    }
}
