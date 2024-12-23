﻿

using AutoMapper;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Models.SkillsModels;


namespace HeroesOfLegends.Businsess.Models
{
    public class AutoMapperConfigurationProfile : Profile
    {

        public AutoMapperConfigurationProfile()
        {
            Map_Profession();
            Map_Race();
            Map_World();
            Map_Narrative();
            Map_Character();
            Map_ProfessionSkill();
            Map_SpecificSkill();
            Map_ValueTuple();  
        }

        private void Map_Profession()
        {
            CreateMap<Profession,ProfessionDto>()
                .ForMember(m => m.BeginnerSkillIds,opt => opt.MapFrom(m => m.BeginnerSkills != null ? m.BeginnerSkills.Select(s => s.Id).ToList() : new List<int>()))
                .ForMember(m => m.AdvancedSkillIds,opt => opt.MapFrom(m => m.AdvancedSkills != null ? m.AdvancedSkills.Select(s => s.Id).ToList() : new List<int>()))
                .ForMember(m => m.ExpertSkillIds,opt => opt.MapFrom(m => m.ExpertSkills != null ? m.ExpertSkills.Select(s => s.Id).ToList() : new List<int>()));
            //.ForMember(m => m.NarrativeIds,opt => opt.MapFrom(m => m.Narratives != null ? m.Narratives.Select(s => s.Id).ToList() : new List<int>()));



            CreateMap<ProfessionDto,Profession>()
                .ForMember(s => s.Narratives,opt => opt.Ignore())
                .ForMember(s => s.BeginnerSkills,opt => opt.Ignore())
                .ForMember(s => s.AdvancedSkills,opt => opt.Ignore())
                .ForMember(s => s.ExpertSkills,opt => opt.Ignore());

            //.ForMember(s => s.BeginnerSkills,opt => opt.MapFrom(s => s.BeginnerSkillIds.Select(id => professionRepository.FindById(id)).Where(skill => skill != null).ToList()));

        }
        private void Map_Race()
        {
            CreateMap<Race,RaceDto>();
            CreateMap<RaceDto,Race>();
        }
        private void Map_World()
        {
            CreateMap<World,WorldDto>()
                .ForMember(m => m.RaceIds,opt => opt.MapFrom(m => m.Races.Select(s => s.RaceId).ToList()))                      // ve WorldDto RaceIds zda napamuju co se tam má vložit do listu
                .ForMember(m => m.NarrativesNames,opt => opt.MapFrom(m => m.Narratives.Select(s => s.NarrativeName).ToList()))
                .ForMember(n => n.NarrativeIds,opt => opt.MapFrom(n => n.Narratives.Select(s => s.Id).ToList()));

            CreateMap<WorldDto,World>()
                .ForMember(m => m.Narratives,opt => opt.Ignore()) // mapování z WorldDto do World se provede v manažeru
                .ForMember(m => m.WorldName,opt => opt.Ignore()); // mapování z WorldDto do World se provede v manažeru

            CreateMap<World,ExtendWorldDto>()
                .ForMember(m => m.RaceIds,opt => opt.MapFrom(m => m.Races.Select(s => s.RaceId).ToList()));
        }
        private void Map_Narrative()
        {
            CreateMap<Narrative,NarrativeDto>()
                .ForMember(m => m.RaceIds,opt => opt.MapFrom(m => m.World.Races.Select(s => s.RaceId)));

            //CreateMap<NarrativeDto,Narrative>();
        }
        private void Map_Character()
        {
            //CreateMap<Character,CharacterDto>()
            // .ForMember(dest => dest.Strengt,opt => opt.MapFrom(src => new TupleValue<int,int>(src.Strengt[0],src.Strengt[1])))
            // .ForMember(dest => dest.Agility,opt => opt.MapFrom(src => new TupleValue<int,int>(src.Agility[0],src.Agility[1])));


            CreateMap<CharacterDto,Character>();
            CreateMap<Character,CharacterDto>();
        }
        private void Map_ProfessionSkill()
        {
            CreateMap<ProfessionSkill,ProfessionSkillDto>();
            CreateMap<ProfessionSkillDto,ProfessionSkill>();
            // .ForMember(dest => dest.SkillClass,opt => opt.MapFrom(src => src.SkillClass));
        }
        private void Map_SpecificSkill()
        {
            CreateMap<BaseSpecificSkill,SpecificSkillDto>();
        }
        private void Map_ValueTuple()
        {
            CreateMap<Tuple<int,int>,int[]>()
            .ConvertUsing(tuple => new int[] { tuple.Item1,tuple.Item2 });
        }

    }
}

