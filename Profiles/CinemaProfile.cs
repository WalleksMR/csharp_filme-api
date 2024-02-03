using AutoMapper;
using filmesAPI.Data.Dtos.Cinema;
using filmesAPI.Models;

namespace filmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(dto => dto.ReadEndereco, opt => opt.MapFrom(cinema => cinema.Endereco));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
