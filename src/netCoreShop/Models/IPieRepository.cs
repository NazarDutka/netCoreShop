using System.Collections.Generic;

namespace netCoreShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int payId);
    }
}