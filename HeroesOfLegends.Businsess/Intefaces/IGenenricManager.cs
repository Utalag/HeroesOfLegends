using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroessOfLegends.Businsess.Intefaces
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


    }
}
