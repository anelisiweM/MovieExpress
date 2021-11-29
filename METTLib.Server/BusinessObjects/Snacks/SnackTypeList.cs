﻿// Generated 03 Nov 2021 16:06 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.Snacks
{
    [Serializable]
    public class SnackTypeList
     : SingularBusinessListBase<SnackTypeList, SnackType>
    {
        #region " Business Methods "

        public SnackType GetItem(int SnackTypeID)
        {
            foreach (SnackType child in this)
            {
                if (child.SnackTypeID == SnackTypeID)
                {
                    return child;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Snack Types";
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

        public static SnackTypeList NewSnackTypeList()
        {
            return new SnackTypeList();
        }

        public SnackTypeList()
        {
            // must have parameter-less constructor
        }

        public static SnackTypeList GetSnackTypeList()
        {
            return DataPortal.Fetch<SnackTypeList>(new Criteria());
        }

        protected void Fetch(SafeDataReader sdr)
        {
            this.RaiseListChangedEvents = false;
            while (sdr.Read())
            {
                this.Add(SnackType.GetSnackType(sdr));
            }
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
                        cm.CommandText = "GetProcs.getSnackTypeList";
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