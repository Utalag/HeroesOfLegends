using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLegends.Data.Builders
{
    public class BuildResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Result { get; set; } = default!;
        public string ErrorMessage { get; set; } = string.Empty;
        public List<string> Errors { get; set; } = new List<string>();
    }
}
