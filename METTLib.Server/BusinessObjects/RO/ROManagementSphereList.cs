﻿// Generated 06 Dec 2018 08:51 - Singular Systems Object Generator Version 2.2.694
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
	public class ROManagementSphereList
	 : METTReadOnlyListBase<ROManagementSphereList, ROManagementSphere>
	{
		#region " Business Methods "

		public ROManagementSphere GetItem(int ManagementSphereID)
		{
			foreach (ROManagementSphere child in this)
			{
				if (child.ManagementSphereID == ManagementSphereID)
				{
					return child;
				}
			}
			return null;
		}

		public override string ToString()
		{
			return "Management Spheres";
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

		public static ROManagementSphereList NewROManagementSphereList()
		{
			return new ROManagementSphereList();
		}

		public ROManagementSphereList()
		{
			// must have parameter-less constructor
		}

		public static ROManagementSphereList GetROManagementSphereList()
		{
			return DataPortal.Fetch<ROManagementSphereList>(new Criteria());
		}

		protected void Fetch(SafeDataReader sdr)
		{
			this.RaiseListChangedEvents = false;
			this.IsReadOnly = false;
			while (sdr.Read())
			{
				this.Add(ROManagementSphere.GetROManagementSphere(sdr));
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
						cm.CommandText = "GetProcs.getROManagementSphereList";
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