using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Helpers
{
    public class QueryObject
    {
        // esto es para stock
        public string? Symbol { get; set; } = null;

        public string? CompanyName { get; set; } = null;


        //esto es para ordenar de mayoe a menor y vice versa
        public string? SortBy { get; set; } = null;

        public bool IsDecsending { get; set; } = false;

        //para paginar en cuantas paginas nos devolvera
        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 20;

    }
}