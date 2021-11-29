﻿// Generated 02 Nov 2021 14:31 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.Basket
{
    [Serializable]
    public class BasketList
     : SingularBusinessListBase<BasketList, Basket>
    {
        #region " Business Methods "

        public Basket GetItem(int BasketID)
        {
            foreach (Basket child in this)
            {
                if (child.BasketID == BasketID)
                {
                    return child;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Baskets";
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

            public int UserID { get; set; }

        }

        public static BasketList NewBasketList()
        {
            return new BasketList();
        }

        public BasketList()
        {
            // must have parameter-less constructor
        }

        public static BasketList GetBasketList()
        {
            return DataPortal.Fetch<BasketList>(new Criteria());
        }

        public static BasketList GetBasketListID(int userID)
        {
            return DataPortal.Fetch<BasketList>(new Criteria() { UserID = userID });
        }

        protected void Fetch(SafeDataReader sdr)
        {
            this.RaiseListChangedEvents = false;
            while (sdr.Read())
            {
                this.Add(Basket.GetBasket(sdr));
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
                        cm.CommandText = "GetProcs.getBasketList";
                        cm.Parameters.AddWithValue("@UserID", Singular.Security.Security.CurrentIdentity.UserID);

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