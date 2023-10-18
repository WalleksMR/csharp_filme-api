using AutoMapper;
using filmesAPI.Data.Dtos;
using filmesAPI.Models;

namespace filmesAPI.Profiles;

public class FilmProfile : Profile
{
  public FilmProfile()
  {
    CreateMap<CreateFilmDto, Filme>();
    CreateMap<UpdateFilmDto, Filme>();
    CreateMap<Filme, UpdateFilmDto>();
  }
}