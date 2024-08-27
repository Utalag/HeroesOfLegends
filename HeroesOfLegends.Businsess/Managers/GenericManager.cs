﻿using AutoMapper;
using HeroesOfLegends.Data;
using HeroesOfLegends.Data.Repositories;
using HeroessOfLegends.Businsess.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroessOfLegends.Businsess.Managers
{
    public abstract class GenericManager<T, TDto> : GenericCRUD<T,HoLDbContext>, IGenericManager<TDto>
        where T : class
        where TDto : class
    {
        protected readonly IMapper mapper;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="db">DbContext</param>
        /// <param name="mapper">mapper</param>
        //public GenerecManager(Db db,IMapper mapper) : base(db)
        public GenericManager(HoLDbContext db,IMapper mapper) : base(db)
        {
            this.mapper = mapper;
        }

        /// <summary>
        /// Vypíše všechny položky
        /// </summary>
        /// <returns></returns>
        public IList<TDto> GetAllData()
        {
            IList<T> date = All();
            return mapper.Map<IList<TDto>>(date);
        }

        /// <summary>
        /// Zobrazí x položek na n-té stránce
        /// </summary>
        /// <param name="page">n-stran(default 0)</param>
        /// <param name="pageSize">x položek na staně</param>
        /// <returns></returns>
        public IList<TDto> GetPage(int page = 0,int pageSize = int.MaxValue)
        {
            IList<T> date = Page(page,pageSize);
            return mapper.Map<IList<TDto>>(date);
        }

        /// <summary>
        /// Vyhledání podle id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TDto? GetDateById(int id)
        {
            T? data = FindById(id);
            if(data is null)
                return null;
            return mapper.Map<TDto>(data);
        }

        /// <summary>
        /// vložení dat z Dto do databáze
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public TDto AddData(TDto dto)
        {
            // T data = mapper.Map<T>(dto); // monsterDto namapuju na monster
            // T addData = Insert(data);    // vložím monstrum do databze
            // return mapper.Map<TDto>(Insert(data)); // mapperem vrátím vkládanou entitu jako MonsterDto

            return mapper.Map<TDto>(Insert(mapper.Map<T>(dto)));
        }

        /// <summary>
        /// smazání záznamu pokud existuje s daným id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TDto? DeleteDate(int id)
        {
            if(!ExistsWithId(id))
                return null;

            T date = FindById(id)!;
            TDto dateDto = mapper.Map<TDto>(date);
            Delete(id);
            return dateDto;
        }

        /// <summary>
        /// Úprava záznamu pokud existuje s daným id
        /// </summary>
        /// <param name="dto">Dto model</param>
        /// <param name="id">id záznamu</param>
        /// <returns></returns>
        public TDto? UpdateData(TDto dto,int id)
        {
            if(!ExistsWithId(id))
                return null;
            // T data = mapper.Map<T>(dto);
            // T updateData = Update(data);
            // return mapper.Map<TDto>(updateData);

            return mapper.Map<TDto>(Update(mapper.Map<T>(dto)));

        }

        //----- Async CRUD-----//

        public async Task<IList<TDto>> GetAllDataAsync()
        {
            IList<T> date = await AllAsync();
            return await Task.Run(()=> mapper.Map<IList<TDto>>(date));
        }

        public async Task<IList<TDto>> GetPageAsyc(int page = 0,int pageSize = int.MaxValue)
        {
            IList<T> date = await PageAsync(page,pageSize);
            return await Task.Run(()=> mapper.Map<IList<TDto>>(date));
        }

        public async Task<TDto?> GetDateByIdAsync(int id)
        {
            T? data = await FindByIdAsync(id);
            if(data is null)
            { return null; }
            return await Task.Run(()=>mapper.Map<TDto>(data));
        }

        public async Task<TDto> AddDataAsync(TDto dto)
        {
            return await Task.Run(()=> mapper.Map<TDto>(Insert(mapper.Map<T>(dto))));
        }

        public async Task<TDto?> DeleteDateAsync(int id)
        {
            if(!ExistsWithId(id))
                return null;

            T date = await FindByIdAsync(id)!;
            TDto dateDto = await Task.Run(()=> mapper.Map<TDto>(date));
            await DeleteAsync(id);
            return dateDto;
        }

        public async Task<TDto?> UpdateDataAsync(TDto dto,int id)
        {
            if(!ExistsWithId(id))
                return null;
            // T data = mapper.Map<T>(dto);
            // T updateData = Update(data);
            // return mapper.Map<TDto>(updateData);

            return await Task.Run(()=> mapper.Map<TDto>(Update(mapper.Map<T>(dto))));

        }

    }
}