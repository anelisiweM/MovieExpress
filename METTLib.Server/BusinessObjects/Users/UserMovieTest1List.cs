// Generated 19 Nov 2021 11:03 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.Users
{
    [Serializable]
    public class UserMovieTest1List
     : SingularBusinessListBase<UserMovieTest1List, UserMovieTest1>
    {
        #region " Business Methods "

        public UserMovieTest1 GetItem(int UserMovieID)
        {
            foreach (UserMovieTest1 child in this)
            {
                if (child.UserMovieID == UserMovieID)
                {
                    return child;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "User Movys";
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

        public static UserMovieTest1List NewUserMovieTest1List()
        {
            return new UserMovieTest1List();
        }

        public UserMovieTest1List()
        {
            // must have parameter-less constructor
        }

        public static UserMovieTest1List GetUserMovieTest1List()
        {
            return DataPortal.Fetch<UserMovieTest1List>(new Criteria());
        }

        public static UserMovieTest1List GetUserMovieTest1ListID(int UserID)
        {
            return DataPortal.Fetch<UserMovieTest1List>(new Criteria() { UserID = UserID });
        }

        protected void Fetch(SafeDataReader sdr)
        {
            this.RaiseListChangedEvents = false;
            while (sdr.Read())
            {
                this.Add(UserMovieTest1.GetUserMovieTest1(sdr));
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
                        cm.CommandText = "GetProcs.getUserMovieTest1List";
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