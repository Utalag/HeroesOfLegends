﻿

using AutoMapper;
using HeroesOfLegends.Data.Models;


namespace HeroesOfLegends.Businsess.Models
{
    public class AutoMapperConfigurationProfile : Profile
    {
        public AutoMapperConfigurationProfile()
        {
            CreateMap<Race,RaceDto>();
            CreateMap<RaceDto,Race>();

            CreateMap<World,WorldDto>()
                .ForMember(m => m.RaceIds,opt => opt.MapFrom(m => m.Races.Select(s => s.RaceId).ToList()))                      // ve WorldDto RaceIds zda napamuju co se tam má vložit do listu
                .ForMember(m => m.NarrativesNames,opt => opt.MapFrom(m => m.Narratives.Select(s => s.NarrativeName).ToList()))
                .ForMember(n => n.NarrativeIds,opt => opt.MapFrom(n => n.Narratives.Select(s => s.Id).ToList()));

            CreateMap<WorldDto,World>()
                .ForMember(m => m.Narratives,opt => opt.Ignore()) // mapování z WorldDto do World se provede v manažeru
                .ForMember(m => m.WorldName,opt => opt.Ignore()); // mapování z WorldDto do World se provede v manažeru

            CreateMap<World,ExtendWorldDto>()
                .ForMember(m => m.RaceIds,opt => opt.MapFrom(m => m.Races.Select(s => s.RaceId).ToList()));

            //CreateMap<Narrative,string>().ConstructUsing(name => name.NarrativeName);

            CreateMap<Narrative,NarrativeDto>()
                .ForMember(m => m.RaceIds,opt => opt.MapFrom(m => m.World.Races.Select(s => s.RaceId)));

            //CreateMap<NarrativeDto,Narrative>();

            //CreateMap<Character,CharacterDto>()
            // .ForMember(dest => dest.Strengt,opt => opt.MapFrom(src => new TupleValue<int,int>(src.Strengt[0],src.Strengt[1])))
            // .ForMember(dest => dest.Agility,opt => opt.MapFrom(src => new TupleValue<int,int>(src.Agility[0],src.Agility[1])));


            CreateMap<CharacterDto,Character>();
            CreateMap<Character,CharacterDto>();


            CreateMap<ProfessionSkill,ProfessionSkillDto>();
                //.ForMember(dest => dest.SkillClass,opt => opt.MapFrom(src => src.SkillClass));

            CreateMap<ProfessionSkillDto,ProfessionSkill>();
               // .ForMember(dest => dest.SkillClass,opt => opt.MapFrom(src => src.SkillClass));




            // Z Model do Dto
            CreateMap<Profession,ProfessionDto>();
            CreateMap<ProfessionDto,Profession>();


            CreateMap<Tuple<int,int>,int[]>()
            .ConvertUsing(tuple => new int[] { tuple.Item1,tuple.Item2 });

        }



    }
}

