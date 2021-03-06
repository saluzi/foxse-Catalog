﻿using CatalogModel.Specification;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Таблица врезок
	/// </summary>
	public class PipeBranch
    {
		public int ID { get; set; }
		public virtual PipingMaterialsClassData SpecName { get; set; }

		//[NotMapped, Display(Description = "/MaterialClass?n=PipingMaterialsClassData")]
		//public string SpecName
		//{
		//	get { return (PipingMaterialsClassData == null || PipingMaterialsClassData.SpecName == null) ? "unset" : PipingMaterialsClassData.SpecName; }
		//	set
		//	{
		//		if (value != null)
		//		{
		//			using (CatalogContext db = new CatalogContext())
		//			{
		//				PipingMaterialsClassData = db.PipingMaterialsClassData.Where(i => i.SpecName == value).FirstOrDefault();
		//				db.SaveChanges();
		//			}
		//		}
		//		else
		//		{
		//			PipingMaterialsClassData = null;
		//		}
		//	}
		//}

		public int HeaderSize { get; set; }
		public int BranchSize { get; set; }
		public float AngleLow { get; set; }
		public float AngleHigh { get; set; }

		public virtual UnitType AngleLowUnitType { get; set; }
		public virtual UnitType AngleHighUnitType { get; set; }
		public virtual UnitType HdrSizeNPDUnitType { get; set; }
		public virtual UnitType BrSizeNPDUnitType { get; set; }

		public virtual ShortCodeHierarchyRule ShortCode { get; set; }
		public virtual ShortCodeHierarchyRule SecondaryShortCode { get; set; }
		public virtual ShortCodeHierarchyRule TertiaryShortCode { get; set; }		
	}
}
