﻿// Generated 19 Nov 2021 14:35 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.TempUser
{
    [Serializable]
    public class NewUserList
     : SingularBusinessListBase<NewUserList, NewUser>
    {
        #region " Business Methods "

        public NewUser GetItem(int UserID)
        {
            foreach (NewUser child in this)
            {
                if (child.UserID == UserID)
                {
                    return child;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Users";
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

        public static NewUserList NewNewUserList()
        {
            return new NewUserList();
        }

        public NewUserList()
        {
            // must have parameter-less constructor
        }

        public static NewUserList GetNewUserList()
        {
            return DataPortal.Fetch<NewUserList>(new Criteria());
        }

        protected void Fetch(SafeDataReader sdr)
        {
            this.RaiseListChangedEvents = false;
            while (sdr.Read())
            {
                this.Add(NewUser.GetNewUser(sdr));
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
                        cm.CommandText = "GetProcs.getNewUserList";
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