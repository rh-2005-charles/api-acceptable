using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos.Stock;
using Api.Models;

namespace Api.Interfaces
{
    public interface IStockRepository
    {
        //conectar este codigo a todo lo campos
        //abstraer el codigo
        Task<List<Stock>> GetAllAsync(Helpers.QueryObject query);

        Task<Stock?> GetByIdAsync(int id);
        Task<Stock?> GetBySymbolAsync(string symbol);   //abstraer el symbol
        Task<Stock> CreateAsync(Stock stockModel);

        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);

        Task<Stock?> DeleteAsync(int id);

        Task<Boolean> StockExists(int id);
    }
}