using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface IitemsWService
    {

        Task<List<ItemsWResponce>> GetAll();

        Task<ItemsWResponce?> GetById(Guid Id);
		Task<List<ItemsWResponce>> GetAllbyPage(int page);
		Task<ItemsWResponce> Create(ItemsWRequest request);
		Task<List<ItemsWResponce>> GetBySearch(string search, int page);
		Task<ItemsWResponce> Update(Guid Id, ItemsWRequest request);

        Task<bool> Delete(Guid Id);
    }
}
