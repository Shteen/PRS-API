using PRS.Core.Entites;

namespace PRS.Modules
{
	public class itemsW
	{
			public Guid Id { get; set; }
			public string CategoryCode { get; set; }
			public string CatDesc { get; set; }
			public int EIitem { get; set; }
			public string DNOType { get; set; }
			public string ItemName { get; set; }
			public string DescriptionItem { get; set; }
			public string DNONUMBER { get; set; }
			public decimal? taxrate { get; set; }
			public string? UMPC { get; set; }
			public decimal? CostPC { get; set; }
			public string? UMCS { get; set; }
			public decimal? CostCS { get; set; }
			public int? PCCS { get; set; }
			public Guid categoryID { get; set; }
			public Category category { get; set; }







	}
}
