﻿using AutoMapper;
using filmesAPI.Data.Dtos.Sessao;
using filmesAPI.Models;

namespace filmesAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
