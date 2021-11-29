﻿// Generated 25 Oct 2021 09:32 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.SportShows
{
    [Serializable]
    public class SportShow
     : SingularBusinessBase<SportShow>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> SportShowIDProperty = RegisterProperty<int>(c => c.SportShowID, "ID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int SportShowID
        {
            get { return GetProperty(SportShowIDProperty); }
        }

        public static PropertyInfo<int> SportGenreIDProperty = RegisterProperty<int>(c => c.SportGenreID, "Sport Genre", 0);
        /// <summary>
        /// Gets and sets the Sport Genre value
        /// </summary>
        [Display(Name = "Sport Genre", Description = ""),
        Required(ErrorMessage = "Sport Genre required")]
        public int SportGenreID
        {
            get { return GetProperty(SportGenreIDProperty); }
            set { SetProperty(SportGenreIDProperty, value); }
        }

        public static PropertyInfo<String> SportShowTitleProperty = RegisterProperty<String>(c => c.SportShowTitle, "Sport Show Title", "");
        /// <summary>
        /// Gets and sets the Sport Show Title value
        /// </summary>
        [Display(Name = "Sport Show Title", Description = "Title of the SportShow"),
        StringLength(200, ErrorMessage = "Sport Show Title cannot be more than 200 characters")]
        public String SportShowTitle
        {
            get { return GetProperty(SportShowTitleProperty); }
            set { SetProperty(SportShowTitleProperty, value); }
        }

        public static PropertyInfo<String> SportShowDescriptionProperty = RegisterProperty<String>(c => c.SportShowDescription, "Sport Show Description", "");
        /// <summary>
        /// Gets and sets the Sport Show Description value
        /// </summary>
        [Display(Name = "Sport Show Description", Description = "Short Description of the SportShow")]
        public String SportShowDescription
        {
            get { return GetProperty(SportShowDescriptionProperty); }
            set { SetProperty(SportShowDescriptionProperty, value); }
        }

        public static PropertyInfo<String> SportShowImageURLProperty = RegisterProperty<String>(c => c.SportShowImageURL, "Sport Show Image URL", "../Media/SportShows/blank.jpg");
        /// <summary>
        /// Gets and sets the Sport Show Image URL value
        /// </summary>
        [Display(Name = "Sport Show Image URL", Description = "")]
        public String SportShowImageURL
        {
            get { return GetProperty(SportShowImageURLProperty); }
            set { SetProperty(SportShowImageURLProperty, value); }
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
        [Display(Name = "Is Active", Description = "Indicator showing if the SportShow is Active"),
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
            return GetProperty(SportShowIDProperty);
        }

        public override string ToString()
        {
            if (this.SportShowTitle.Length == 0)
            {
                if (this.IsNew)
                {
                    return String.Format("New {0}", "Sport Show");
                }
                else
                {
                    return String.Format("Blank {0}", "Sport Show");
                }
            }
            else
            {
                return this.SportShowTitle;
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
            // Set any variables here, not in the constructor or NewSportShow() method.
        }

        public static SportShow NewSportShow()
        {
            return DataPortal.CreateChild<SportShow>();
        }

        public SportShow()
        {
            MarkAsChild();
        }

        internal static SportShow GetSportShow(SafeDataReader dr)
        {
            var s = new SportShow();
            s.Fetch(dr);
            return s;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            using (BypassPropertyChecks)
            {
                int i = 0;
                LoadProperty(SportShowIDProperty, sdr.GetInt32(i++));
                LoadProperty(SportGenreIDProperty, sdr.GetInt32(i++));
                LoadProperty(SportShowTitleProperty, sdr.GetString(i++));
                LoadProperty(SportShowDescriptionProperty, sdr.GetString(i++));
                LoadProperty(SportShowImageURLProperty, sdr.GetString(i++));
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

            AddPrimaryKeyParam(cm, SportShowIDProperty);

            cm.Parameters.AddWithValue("@SportGenreID", GetProperty(SportGenreIDProperty));
            cm.Parameters.AddWithValue("@SportShowTitle", GetProperty(SportShowTitleProperty));
            cm.Parameters.AddWithValue("@SportShowDescription", GetProperty(SportShowDescriptionProperty));
            cm.Parameters.AddWithValue("@SportShowImageURL", GetProperty(SportShowImageURLProperty));
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
                    LoadProperty(SportShowIDProperty, scm.Parameters["@SportShowID"].Value);
                }
            };
        }

        protected override void SaveChildren()
        {
            // No Children
        }

        protected override void SetupDeleteCommand(SqlCommand cm)
        {
            cm.Parameters.AddWithValue("@SportShowID", GetProperty(SportShowIDProperty));
        }

        #endregion

    }

}