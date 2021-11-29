﻿// Generated 12 Jan 2021 06:26 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.Movies
{
  [Serializable]
  public class UserMovieList
   : MEBusinessListBase<UserMovieList, UserMovie>
  {
    #region " Business Methods "

    public UserMovie GetItem(int UserMovieID)
    {
      foreach (UserMovie child in this)
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
      return "User Movies";
    }

    #endregion

    #region " Data Access "

    [Serializable]
    public class Criteria
      : CriteriaBase<Criteria>
    {

      public int? MovieID = null;
            public int? UserID = null;
            public Criteria()
      {
      }

      public Criteria(int? MovieID)
      {
        this.MovieID = MovieID;
                this.UserID = UserID;
      }

    }

    public static UserMovieList NewUserMovieList()
    {
      return new UserMovieList();
    }

    public UserMovieList()
    {
      // must have parameter-less constructor
    }

    public static UserMovieList GetUserMovieList()
    {
      return DataPortal.Fetch<UserMovieList>(new Criteria());
    }

        public static UserMovieList GetUserMovieListID(int MovieID)
        {
            return DataPortal.Fetch<UserMovieList>(new Criteria() { MovieID = MovieID });
        }

        protected void Fetch(SafeDataReader sdr)
    {
      this.RaiseListChangedEvents = false;
      while (sdr.Read())
      {
        this.Add(UserMovie.GetUserMovie(sdr));
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
            cm.CommandText = "GetProcs.getUserMovieList";

            // Add any parameters here
             cm.Parameters.AddWithValue("@UserID", Singular.Security.Security.CurrentIdentity.UserID);
             cm.Parameters.AddWithValue("@MovieID", Singular.Misc.NothingDBNull(crit.MovieID));

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