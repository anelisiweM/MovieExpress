﻿// Generated 04 Nov 2021 10:22 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.Snack
{
    [Serializable]
    public class SnackList
     : SingularBusinessListBase<SnackList, Snack>
    {
        #region " Business Methods "

        public Snack GetItem(int SnackID)
        {
            foreach (Snack child in this)
            {
                if (child.SnackID == SnackID)
                {
                    return child;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Snacks";
        }

        #endregion

        #region " Data Access "

        [Serializable]
        public class Criteria
          : CriteriaBase<Criteria>
        {

            public int snackID;
            public int? quantity = null;



            public Criteria(int SnackID, int? Quantity)
            {
                snackID = SnackID;
                quantity = Quantity;
            }

            public Criteria()
            {
            }

        }

        public static SnackList NewSnackList()
        {
            return new SnackList();
        }

        public SnackList()
        {
            // must have parameter-less constructor
        }

        public static SnackList GetSnackList()
        {
            return DataPortal.Fetch<SnackList>(new Criteria());
        }

        public static SnackList GetSnackListSnackID(int SnackID)
        {
            return DataPortal.Fetch<SnackList>(new Criteria(SnackID, null));
        }

        protected void Fetch(SafeDataReader sdr)
        {
            this.RaiseListChangedEvents = false;
            while (sdr.Read())
            {
                this.Add(Snack.GetSnack(sdr));
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
                        cm.CommandText = "GetProcs.getSnackList";
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