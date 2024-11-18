using Borsa.Dtos.BorsaIzleme;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borsa.Client
{
    public interface IBorsaClient
    {
        [Get("/borsa-islemleri/borsa-izleme")]
        Task<ApiResponse<BorsaIzlemeResponseDto>> BorsaIzleme(BorsaIzlemeRequestDto request);
    }
}
