using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tammU.Domain.Commons
{
    public class BaseResponse<TSource>
    {
        public TSource Data { get; set; }

        public string ErrorMessage { get; set; }
    }
}
