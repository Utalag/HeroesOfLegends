namespace HeroesOfLegends.Businsess.Interfaces
{
    public interface IGenericManager<TDto>
        where TDto : class
    {
        TDto AddData(TDto dto);
        TDto? DeleteDate(int id);
        IList<TDto> GetAllData();
        TDto? GetDateById(int id);
        IList<TDto> GetPage(int page = 0,int pageSize = int.MaxValue);
        TDto? UpdateData(TDto dto,int id);

        //-----Async-----//

        Task<TDto> AddDataAsync(TDto dto);
        Task<TDto?> DeleteDateAsync(int id);
        Task<IList<TDto>> GetAllDataAsync();
        Task<TDto?> GetDateByIdAsync(int id);
        Task<IList<TDto>> GetPageAsyc(int page = 0,int pageSize = int.MaxValue);
        Task<TDto?> UpdateDataAsync(TDto dto,int id);

    }
}
