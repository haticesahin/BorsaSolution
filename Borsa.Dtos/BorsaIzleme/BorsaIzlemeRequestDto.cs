using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borsa.Dtos.BorsaIzleme
{
    public class BorsaIzlemeRequestDto :  IRequest<BorsaIzlemeResponseDto> //BaseApiRequest,
    {
    }
}
