using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Interfaces
{
    public interface IBlocCardService
    {
        Task GetCards();
        Task GetCardsById();
        Task FundCard();
        Task BlockCard();
        Task FreezeCard();
    }
}
