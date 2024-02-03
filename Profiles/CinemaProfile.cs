using AutoMapper;
using filmesAPI.Data.Dtos.Cinema;
using filmesAPI.Models;

namespace filmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
