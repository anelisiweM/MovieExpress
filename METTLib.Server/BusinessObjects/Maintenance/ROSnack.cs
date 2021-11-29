﻿// Generated 21 Oct 2021 11:27 - Singular Systems Object Generator Version 2.2.694
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
    public class ROSnack
     : SingularReadOnlyBase<ROSnack>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> SnackIDProperty = RegisterProperty<int>(c => c.SnackID, "SnackID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int SnackID
        {
            get { return GetProperty(SnackIDProperty); }
        }

        public static PropertyInfo<int> SnackTypeIDProperty = RegisterProperty<int>(c => c.SnackTypeID, "SnackTypeID", 0);
        /// <summary>
        /// Gets the Snack Type value
        /// </summary>
        [Display(Name = "Snack Type", Description = "Foreign Key - Snack Type ID")]
        public int SnackTypeID
        {
            get { return GetProperty(SnackTypeIDProperty); }
        }

        public static PropertyInfo<String> SnackTitleProperty = RegisterProperty<String>(c => c.SnackTitle, "SnackTitle", "");
        /// <summary>
        /// Gets the Snack Title value
        /// </summary>
        [Display(Name = "Snack Title", Description = "Title of the Snack")]
        public String SnackTitle
        {
            get { return GetProperty(SnackTitleProperty); }
        }

        public static PropertyInfo<String> SnackDescriptionProperty = RegisterProperty<String>(c => c.SnackDescription, "SnackDescription", "");
        /// <summary>
        /// Gets the Snack Description value
        /// </summary>
        [Display(Name = "Snack Description", Description = "Short Description of the Snack")]
        public String SnackDescription
        {
            get { return GetProperty(SnackDescriptionProperty); }
        }

        public static PropertyInfo<String> SnackImageURLProperty = RegisterProperty<String>(c => c.SnackImageURL, "Snack Image URL", "../Media/Snacks/blank.jpg");
        /// <summary>
        /// Gets the Snack Image URL value
        /// </summary>
        [Display(Name = "Snack Image URL", Description = "")]
        public String SnackImageURL
        {
            get { return GetProperty(SnackImageURLProperty); }
        }

        public static PropertyInfo<Decimal> PriceProperty = RegisterProperty<Decimal>(c => c.Price, "Price", Convert.ToDecimal(50));
        /// <summary>
        /// Gets the Price value
        /// </summary>
        [Display(Name = "Price", Description = "")]
        public Decimal Price
        {
            get { return GetProperty(PriceProperty); }
        }

        public static PropertyInfo<DateTime> ReleaseDateProperty = RegisterProperty<DateTime>(c => c.ReleaseDate, "ReleaseDate");
        /// <summary>
        /// Gets the Release Date value
        /// </summary>
        [Display(Name = "Release Date", Description = "Date of Release")]
        public DateTime ReleaseDate
        {
            get
            {
                return GetProperty(ReleaseDateProperty);
            }
        }

        public static PropertyInfo<Boolean> IsActiveIndProperty = RegisterProperty<Boolean>(c => c.IsActiveInd, "IsActive", true);
        /// <summary>
        /// Gets the Is Active value
        /// </summary>
        [Display(Name = "Is Active", Description = "Indicator showing if the Snack is Active")]
        public Boolean IsActiveInd
        {
            get { return GetProperty(IsActiveIndProperty); }
        }

        public static PropertyInfo<DateTime?> DeletedDateProperty = RegisterProperty<DateTime?>(c => c.DeletedDate, "DeletedDate");
        /// <summary>
        /// Gets the Deleted Date value
        /// </summary>
        [Display(Name = "Deleted Date", Description = "When this record was deleted")]
        public DateTime? DeletedDate
        {
            get
            {
                return GetProperty(DeletedDateProperty);
            }
        }

        public static PropertyInfo<int> DeletedByProperty = RegisterProperty<int>(c => c.DeletedBy, "DeletedBy", 0);
        /// <summary>
        /// Gets the Deleted By value
        /// </summary>
        [Display(Name = "Deleted By", Description = "User that deleted the record")]
        public int DeletedBy
        {
            get { return GetProperty(DeletedByProperty); }
        }

        public static PropertyInfo<SmartDate> CreatedDateProperty = RegisterProperty<SmartDate>(c => c.CreatedDate, "CreatedDate", new SmartDate(DateTime.Now));
        /// <summary>
        /// Gets the Created Date value
        /// </summary>
        [Display(AutoGenerateField = false)]
        public SmartDate CreatedDate
        {
            get { return GetProperty(CreatedDateProperty); }
        }

        public static PropertyInfo<int> CreatedByProperty = RegisterProperty<int>(c => c.CreatedBy, "CreatedBy", 0);
        /// <summary>
        /// Gets the Created By value
        /// </summary>
        [Display(AutoGenerateField = false)]
        public int CreatedBy
        {
            get { return GetProperty(CreatedByProperty); }
        }

        public static PropertyInfo<SmartDate> ModifiedDateProperty = RegisterProperty<SmartDate>(c => c.ModifiedDate, "ModifiedDate", new SmartDate(DateTime.Now));
        /// <summary>
        /// Gets the Modified Date value
        /// </summary>
        [Display(AutoGenerateField = false)]
        public SmartDate ModifiedDate
        {
            get { return GetProperty(ModifiedDateProperty); }
        }

        public static PropertyInfo<int> ModifiedByProperty = RegisterProperty<int>(c => c.ModifiedBy, "ModifiedBy", 0);
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
            return GetProperty(SnackIDProperty);
        }

        public override string ToString()
        {
            return this.SnackTitle;
        }

        #endregion

        #endregion

        #region " Data Access & Factory Methods "

        internal static ROSnack GetROSnack(SafeDataReader dr)
        {
            var r = new ROSnack();
            r.Fetch(dr);
            return r;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            int i = 0;
            LoadProperty(SnackIDProperty, sdr.GetInt32(i++));
            LoadProperty(SnackTypeIDProperty, sdr.GetInt32(i++));
            LoadProperty(SnackTitleProperty, sdr.GetString(i++));
            LoadProperty(SnackDescriptionProperty, sdr.GetString(i++));
            LoadProperty(SnackImageURLProperty, sdr.GetString(i++));
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

        #endregion

    }

}