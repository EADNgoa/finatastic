




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `DefaultConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=FintasticLocal;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace Fintastic
{

	public partial class Repository : Database
	{
		public Repository() 
			: base("DefaultConnection")
		{
			CommonConstruct();
		}

		public Repository(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			Repository GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static Repository GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new Repository();
        }

		[ThreadStatic] static Repository _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

	}
	



    

	[TableName("dbo.__RefactorLog")]



	[PrimaryKey("OperationKey", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class __RefactorLog  
    {



		[Column] public Guid OperationKey { get; set; }



	}

    

	[TableName("dbo.Agents")]



	[PrimaryKey("AgentID")]




	[ExplicitColumns]

    public partial class Agent  
    {



		[Column] public int AgentID { get; set; }





		[Column("Agent")] public string _Agent { get; set; }



	}

    

	[TableName("dbo.Banks")]



	[PrimaryKey("BankID")]




	[ExplicitColumns]

    public partial class Bank  
    {



		[Column] public int BankID { get; set; }





		[Column("Bank")] public string _Bank { get; set; }





		[Column] public string AcNo { get; set; }





		[Column] public string Comment { get; set; }



	}

    

	[TableName("dbo.Categories")]



	[PrimaryKey("CatID")]




	[ExplicitColumns]

    public partial class Category  
    {



		[Column] public int CatID { get; set; }





		[Column("Category")] public string _Category { get; set; }





		[Column] public bool InOut { get; set; }



	}

    

	[TableName("dbo.FDs")]



	[PrimaryKey("FDID")]




	[ExplicitColumns]

    public partial class FD  
    {



		[Column] public int FDID { get; set; }





		[Column] public string FDNo { get; set; }





		[Column] public bool Active { get; set; }





		[Column] public string FDName { get; set; }





		[Column] public DateTime? BuyDate { get; set; }





		[Column] public decimal Interest { get; set; }





		[Column] public decimal Amount { get; set; }





		[Column] public DateTime Maturity { get; set; }





		[Column] public string Comment { get; set; }



	}

    

	[TableName("dbo.MFDetails")]



	[PrimaryKey("MFDetailID")]




	[ExplicitColumns]

    public partial class MFDetail  
    {



		[Column] public int MFDetailID { get; set; }





		[Column] public int MFID { get; set; }





		[Column] public DateTime TDate { get; set; }





		[Column] public int? SourceBankID { get; set; }





		[Column] public int? SourceMFID { get; set; }





		[Column] public decimal? BuyAmountRs { get; set; }





		[Column] public decimal? SellAmountRs { get; set; }





		[Column] public string Comment { get; set; }



	}

    

	[TableName("dbo.MFPerf")]



	[PrimaryKey("TDate", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class MFPerf  
    {



		[Column] public DateTime TDate { get; set; }





		[Column] public int MFID { get; set; }





		[Column] public decimal? Amount { get; set; }





		[Column] public decimal? Yeild { get; set; }



	}

    

	[TableName("dbo.MFs")]



	[PrimaryKey("MFID")]




	[ExplicitColumns]

    public partial class MF  
    {



		[Column] public int MFID { get; set; }





		[Column] public bool Active { get; set; }





		[Column] public string Scheme { get; set; }





		[Column] public int AgentID { get; set; }





		[Column] public string Folio { get; set; }





		[Column] public string ISIN { get; set; }



	}

    

	[TableName("dbo.SBAc")]



	[PrimaryKey("SBAcID")]




	[ExplicitColumns]

    public partial class SBAc  
    {



		[Column] public int SBAcID { get; set; }





		[Column] public int? BankID { get; set; }





		[Column] public DateTime? TDate { get; set; }





		[Column] public decimal? AmtIn { get; set; }





		[Column] public decimal? AmtOut { get; set; }





		[Column] public string Comment { get; set; }





		[Column] public int? CatID { get; set; }





		[Column] public int? MFID { get; set; }





		[Column] public int? ShareID { get; set; }





		[Column] public int? FDID { get; set; }



	}

    

	[TableName("dbo.ShareDetails")]



	[PrimaryKey("ShareDetailID")]




	[ExplicitColumns]

    public partial class ShareDetail  
    {



		[Column] public int ShareDetailID { get; set; }





		[Column] public int ShareID { get; set; }





		[Column] public DateTime TDate { get; set; }





		[Column] public decimal? BuyAmountRs { get; set; }





		[Column] public decimal? SellAmountRs { get; set; }





		[Column] public int? Units { get; set; }





		[Column] public string Comment { get; set; }



	}

    

	[TableName("dbo.Shares")]



	[PrimaryKey("ShareID")]




	[ExplicitColumns]

    public partial class Share  
    {



		[Column] public int ShareID { get; set; }





		[Column] public bool Active { get; set; }





		[Column] public string Symbol { get; set; }





		[Column] public string Company { get; set; }



	}


}
