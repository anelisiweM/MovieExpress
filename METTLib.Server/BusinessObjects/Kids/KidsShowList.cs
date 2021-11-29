﻿// Generated 22 Oct 2021 16:08 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.KidsShows
{
    [Serializable]
    public class KidsShowList
     : SingularBusinessListBase<KidsShowList, KidsShow>
    {
        #region " Business Methods "

        public KidsShow GetItem(int KidID)
        {
            foreach (KidsShow child in this)
            {
                if (child.KidID == KidID)
                {
                    return child;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Kids";
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

        public static KidsShowList NewKidsShowList()
        {
            return new KidsShowList();
        }

        public KidsShowList()
        {
            // must have parameter-less constructor
        }

        public static KidsShowList GetKidsShowList()
        {
            return DataPortal.Fetch<KidsShowList>(new Criteria());
        }

        protected void Fetch(SafeDataReader sdr)
        {
            this.RaiseListChangedEvents = false;
            while (sdr.Read())
            {
                this.Add(KidsShow.GetKidsShow(sdr));
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
                        cm.CommandText = "GetProcs.getKidsShowList";
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