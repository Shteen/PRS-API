using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace PRS.Service.Services
{
    public class SupplierService : ISupplierService
	{
		private readonly SupplierConnection _context;

		private readonly ISupplierRepository _supp;

		public SupplierService(SupplierConnection context, ISupplierRepository supp)
		{

			_context = context;
			_supp = supp;
		}

		public async Task<SupplierResponce> Get(int? supno)
		{
			var supp = await _supp.GetBySupplierNo(supno);

			var suppDto = supp?.Adapt<SupplierResponce>();

			return suppDto;
		}

		public async Task<List<SupplierResponce>> GetAll()
		{
			var supp = await _supp.GetAll();

			// Assuming _supp.GetAll() returns a List<Supplier>

			var suppDto = supp?.Adapt<List<SupplierResponce>>();

			return suppDto;
		}

		public async Task<List<SupplierResponce>> GetAllbyPage(int page)
		{
			int pageSize = 20; // Set the default page size
			var salaries = await _supp.GetAll();
			var skipAmount = (page - 1) * pageSize; // Adjusted to start from page 1
			var paginatedSalaries = salaries.Skip(skipAmount).Take(pageSize).ToList();
			var salaryDto = paginatedSalaries.Adapt<List<SupplierResponce>>();
			return salaryDto;
		}

		public async Task<List<SupplierResponce>> GetBySearch(string search)
		{
			var employeeDetails = await _supp.GetBySearch(search);

			var employeeDetailsDto = employeeDetails.Adapt<List<SupplierResponce>>();
			return employeeDetailsDto;
		}

		public async Task<SupplierResponce> Update(Guid id, SupplierRequest request)
		{
			var supp = await _supp.GetById(id);


			if (supp == null) return null;



			request.Adapt(supp);

			await _supp.SaveChangesAysnc();

			return _supp.Adapt<SupplierResponce>();
		}
	}
}
