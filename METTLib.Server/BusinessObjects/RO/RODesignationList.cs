﻿// Generated 25 Mar 2019 09:32 - Singular Systems Object Generator Version 2.2.694
//<auto-generated/>
using System;
using Csla;
using Csla.Serialization;
using Csla.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Singular;
using System.Data;
using System.Data.SqlClient;


namespace METTLib.RO
{
	[Serializable]
	public class RODesignationList
	 : METTReadOnlyListBase<RODesignationList, RODesignation>
	{
		#region " Business Methods "

		public RODesignation GetItem(int DesignationID)
		{
			foreach (RODesignation child in this)
			{
				if (child.DesignationID == DesignationID)
				{
					return child;
				}
			}
			return null;
		}

		public override string ToString()
		{
			return "Designations";
		}

		#endregion

		#region " Data Access "

		[Serializable]
		public class Criteria
			: CriteriaBase<Criteria>
		{
			public Criteria()
			{
			}

		}

		public static RODesignationList NewRODesignationList()
		{
			return new RODesignationList();
		}

		public RODesignationList()
		{
			// must have parameter-less constructor
		}

		public static RODesignationList GetRODesignationList()
		{
			return DataPortal.Fetch<RODesignationList>(new Criteria());
		}

		protected void Fetch(SafeDataReader sdr)
		{
			this.RaiseListChangedEvents = false;
			this.IsReadOnly = false;
			while (sdr.Read())
			{
				this.Add(RODesignation.GetRODesignation(sdr));
			}
			this.IsReadOnly = true;
			this.RaiseListChangedEvents = true;
		}

		protected override void DataPortal_Fetch(Object criteria)
		{
			Criteria crit = (Criteria)criteria;
			using (SqlConnection cn = new SqlConnection(Singular.Settings.ConnectionString))
			{
				cn.Open();
				try
				{
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "GetProcs.getRODesignationList";
						using (SafeDataReader sdr = new SafeDataReader(cm.ExecuteReader()))
						{
							Fetch(sdr);
						}
					}
				}
				finally
				{
					cn.Close();
				}
			}
		}

		#endregion

	}

}