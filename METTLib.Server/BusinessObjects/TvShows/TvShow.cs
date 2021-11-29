﻿// Generated 22 Oct 2021 09:10 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.TvShows
{
    [Serializable]
    public class TvShow
     : SingularBusinessBase<TvShow>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> TvShowIDProperty = RegisterProperty<int>(c => c.TvShowID, "ID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int TvShowID
        {
            get { return GetProperty(TvShowIDProperty); }
        }

        public static PropertyInfo<int> MovieGenreIDProperty = RegisterProperty<int>(c => c.MovieGenreID, "Movie Genre", 0);
        /// <summary>
        /// Gets and sets the Movie Genre value
        /// </summary>
        [Display(Name = "Movie Genre", Description = ""),
        Required(ErrorMessage = "Movie Genre required")]
        public int MovieGenreID
        {
            get { return GetProperty(MovieGenreIDProperty); }
            set { SetProperty(MovieGenreIDProperty, value); }
        }

        public static PropertyInfo<String> TvShowTitleProperty = RegisterProperty<String>(c => c.TvShowTitle, "Tv Show Title", "");
        /// <summary>
        /// Gets and sets the Tv Show Title value
        /// </summary>
        [Display(Name = "Tv Show Title", Description = "Title of the TvShow"),
        StringLength(200, ErrorMessage = "Tv Show Title cannot be more than 200 characters")]
        public String TvShowTitle
        {
            get { return GetProperty(TvShowTitleProperty); }
            set { SetProperty(TvShowTitleProperty, value); }
        }

        public static PropertyInfo<String> TvShowDescriptionProperty = RegisterProperty<String>(c => c.TvShowDescription, "Tv Show Description", "");
        /// <summary>
        /// Gets and sets the Tv Show Description value
        /// </summary>
        [Display(Name = "Tv Show Description", Description = "Short Description of the TvShow")]
        public String TvShowDescription
        {
            get { return GetProperty(TvShowDescriptionProperty); }
            set { SetProperty(TvShowDescriptionProperty, value); }
        }

        public static PropertyInfo<String> TvShowImageURLProperty = RegisterProperty<String>(c => c.TvShowImageURL, "Tv Show Image URL", "../Media/TvShows/blank.jpg");
        /// <summary>
        /// Gets and sets the Tv Show Image URL value
        /// </summary>
        [Display(Name = "Tv Show Image URL", Description = "")]
        public String TvShowImageURL
        {
            get { return GetProperty(TvShowImageURLProperty); }
            set { SetProperty(TvShowImageURLProperty, value); }
        }

        public static PropertyInfo<Decimal> PriceProperty = RegisterProperty<Decimal>(c => c.Price, "Price", Convert.ToDecimal(50));
        /// <summary>
        /// Gets and sets the Price value
        /// </summary>
        [Display(Name = "Price", Description = ""),
        Required(ErrorMessage = "Price required")]
        public Decimal Price
        {
            get { return GetProperty(PriceProperty); }
            set { SetProperty(PriceProperty, value); }
        }

        public static PropertyInfo<DateTime> ReleaseDateProperty = RegisterProperty<DateTime>(c => c.ReleaseDate, "Release Date");
        /// <summary>
        /// Gets and sets the Release Date value
        /// </summary>
        [Display(Name = "Release Date", Description = "Date of Release"),
        Required(ErrorMessage = "Release Date required")]
        public DateTime ReleaseDate
        {
            get
            {
                return GetProperty(ReleaseDateProperty);
            }
            set
            {
                SetProperty(ReleaseDateProperty, value);
            }
        }

        public static PropertyInfo<Boolean> IsActiveIndProperty = RegisterProperty<Boolean>(c => c.IsActiveInd, "Is Active", true);
        /// <summary>
        /// Gets and sets the Is Active value
        /// </summary>
        [Display(Name = "Is Active", Description = "Indicator showing if the TvShow is Active"),
        Required(ErrorMessage = "Is Active required")]
        public Boolean IsActiveInd
        {
            get { return GetProperty(IsActiveIndProperty); }
            set { SetProperty(IsActiveIndProperty, value); }
        }

        public static PropertyInfo<DateTime?> DeletedDateProperty = RegisterProperty<DateTime?>(c => c.DeletedDate, "Deleted Date");
        /// <summary>
        /// Gets and sets the Deleted Date value
        /// </summary>
        [Display(Name = "Deleted Date", Description = "When this record was deleted")]
        public DateTime? DeletedDate
        {
            get
            {
                return GetProperty(DeletedDateProperty);
            }
            set
            {
                SetProperty(DeletedDateProperty, value);
            }
        }

        public static PropertyInfo<int> DeletedByProperty = RegisterProperty<int>(c => c.DeletedBy, "Deleted By", 0);
        /// <summary>
        /// Gets and sets the Deleted By value
        /// </summary>
        [Display(Name = "Deleted By", Description = "User that deleted the record")]
        public int DeletedBy
        {
            get { return GetProperty(DeletedByProperty); }
            set { SetProperty(DeletedByProperty, value); }
        }

        public static PropertyInfo<SmartDate> CreatedDateProperty = RegisterProperty<SmartDate>(c => c.CreatedDate, "Created Date", new SmartDate(DateTime.Now));
        /// <summary>
        /// Gets the Created Date value
        /// </summary>
        [Display(AutoGenerateField = false)]
        public SmartDate CreatedDate
        {
            get { return GetProperty(CreatedDateProperty); }
        }

        public static PropertyInfo<int> CreatedByProperty = RegisterProperty<int>(c => c.CreatedBy, "Created By", 0);
        /// <summary>
        /// Gets the Created By value
        /// </summary>
        [Display(AutoGenerateField = false)]
        public int CreatedBy
        {
            get { return GetProperty(CreatedByProperty); }
        }

        public static PropertyInfo<SmartDate> ModifiedDateProperty = RegisterProperty<SmartDate>(c => c.ModifiedDate, "Modified Date", new SmartDate(DateTime.Now));
        /// <summary>
        /// Gets the Modified Date value
        /// </summary>
        [Display(AutoGenerateField = false)]
        public SmartDate ModifiedDate
        {
            get { return GetProperty(ModifiedDateProperty); }
        }

        public static PropertyInfo<int> ModifiedByProperty = RegisterProperty<int>(c => c.ModifiedBy, "Modified By", 0);
        /// <summary>
        /// Gets the Modified By value
        /// </summary>
        [Display(AutoGenerateField = false)]
        public int ModifiedBy
        {
            get { return GetProperty(ModifiedByProperty); }
        }

        #endregion

        #region " Methods "

        protected override object GetIdValue()
        {
            return GetProperty(TvShowIDProperty);
        }

        public override string ToString()
        {
            if (this.TvShowTitle.Length == 0)
            {
                if (this.IsNew)
                {
                    return String.Format("New {0}", "Tv Show");
                }
                else
                {
                    return String.Format("Blank {0}", "Tv Show");
                }
            }
            else
            {
                return this.TvShowTitle;
            }
        }

        #endregion

        #endregion

        #region " Validation Rules "

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
        }

        #endregion

        #region " Data Access & Factory Methods "

        protected override void OnCreate()
        {
            // This is called when a new object is created
            // Set any variables here, not in the constructor or NewTvShow() method.
        }

        public static TvShow NewTvShow()
        {
            return DataPortal.CreateChild<TvShow>();
        }

        public TvShow()
        {
            MarkAsChild();
        }

        internal static TvShow GetTvShow(SafeDataReader dr)
        {
            var t = new TvShow();
            t.Fetch(dr);
            return t;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            using (BypassPropertyChecks)
            {
                int i = 0;
                LoadProperty(TvShowIDProperty, sdr.GetInt32(i++));
                LoadProperty(MovieGenreIDProperty, sdr.GetInt32(i++));
                LoadProperty(TvShowTitleProperty, sdr.GetString(i++));
                LoadProperty(TvShowDescriptionProperty, sdr.GetString(i++));
                LoadProperty(TvShowImageURLProperty, sdr.GetString(i++));
                LoadProperty(PriceProperty, sdr.GetDecimal(i++));
                LoadProperty(ReleaseDateProperty, sdr.GetValue(i++));
                LoadProperty(IsActiveIndProperty, sdr.GetBoolean(i++));
                LoadProperty(DeletedDateProperty, sdr.GetValue(i++));
                LoadProperty(DeletedByProperty, sdr.GetInt32(i++));
                LoadProperty(CreatedDateProperty, sdr.GetSmartDate(i++));
                LoadProperty(CreatedByProperty, sdr.GetInt32(i++));
                LoadProperty(ModifiedDateProperty, sdr.GetSmartDate(i++));
                LoadProperty(ModifiedByProperty, sdr.GetInt32(i++));
            }

            MarkAsChild();
            MarkOld();
            BusinessRules.CheckRules();
        }

        protected override Action<SqlCommand> SetupSaveCommand(SqlCommand cm)
        {
            LoadProperty(ModifiedByProperty, Settings.CurrentUser.UserID);

            AddPrimaryKeyParam(cm, TvShowIDProperty);

            cm.Parameters.AddWithValue("@MovieGenreID", GetProperty(MovieGenreIDProperty));
            cm.Parameters.AddWithValue("@TvShowTitle", GetProperty(TvShowTitleProperty));
            cm.Parameters.AddWithValue("@TvShowDescription", GetProperty(TvShowDescriptionProperty));
            cm.Parameters.AddWithValue("@TvShowImageURL", GetProperty(TvShowImageURLProperty));
            cm.Parameters.AddWithValue("@Price", GetProperty(PriceProperty));
            cm.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            cm.Parameters.AddWithValue("@IsActiveInd", GetProperty(IsActiveIndProperty));
            cm.Parameters.AddWithValue("@DeletedDate", Singular.Misc.NothingDBNull(DeletedDate));
            cm.Parameters.AddWithValue("@DeletedBy", GetProperty(DeletedByProperty));
            cm.Parameters.AddWithValue("@ModifiedBy", GetProperty(ModifiedByProperty));

            return (scm) =>
            {
    // Post Save
    if (this.IsNew)
                {
                    LoadProperty(TvShowIDProperty, scm.Parameters["@TvShowID"].Value);
                }
            };
        }

        protected override void SaveChildren()
        {
            // No Children
        }

        protected override void SetupDeleteCommand(SqlCommand cm)
        {
            cm.Parameters.AddWithValue("@TvShowID", GetProperty(TvShowIDProperty));
        }

        #endregion

    }

}