﻿// Generated 17 Nov 2021 14:35 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.Promotions
{
    [Serializable]
    public class SnackPromo
     : SingularBusinessBase<SnackPromo>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> SnackIDProperty = RegisterProperty<int>(c => c.SnackID, "ID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int SnackID
        {
            get { return GetProperty(SnackIDProperty); }
        }

        public static PropertyInfo<int> SnackTypeIDProperty = RegisterProperty<int>(c => c.SnackTypeID, "Snack Type", 0);
        /// <summary>
        /// Gets and sets the Snack Type value
        /// </summary>
        [Display(Name = "Snack Type", Description = "Foreign Key - Snack Genre ID"),
        Required(ErrorMessage = "Snack Type required")]
        public int SnackTypeID
        {
            get { return GetProperty(SnackTypeIDProperty); }
            set { SetProperty(SnackTypeIDProperty, value); }
        }

        public static PropertyInfo<String> SnackTitleProperty = RegisterProperty<String>(c => c.SnackTitle, "Snack Title", "");
        /// <summary>
        /// Gets and sets the Snack Title value
        /// </summary>
        [Display(Name = "Snack Title", Description = "Title of the Snack"),
        StringLength(200, ErrorMessage = "Snack Title cannot be more than 200 characters")]
        public String SnackTitle
        {
            get { return GetProperty(SnackTitleProperty); }
            set { SetProperty(SnackTitleProperty, value); }
        }

        public static PropertyInfo<String> SnackDescriptionProperty = RegisterProperty<String>(c => c.SnackDescription, "Snack Description", "");
        /// <summary>
        /// Gets and sets the Snack Description value
        /// </summary>
        [Display(Name = "Snack Description", Description = "Short Description of the Snack")]
        public String SnackDescription
        {
            get { return GetProperty(SnackDescriptionProperty); }
            set { SetProperty(SnackDescriptionProperty, value); }
        }

        public static PropertyInfo<String> SnackImageURLProperty = RegisterProperty<String>(c => c.SnackImageURL, "Snack Image URL", "../Media/Snacks/blank.jpg");
        /// <summary>
        /// Gets and sets the Snack Image URL value
        /// </summary>
        [Display(Name = "Snack Image URL", Description = "")]
        public String SnackImageURL
        {
            get { return GetProperty(SnackImageURLProperty); }
            set { SetProperty(SnackImageURLProperty, value); }
        }

        public static PropertyInfo<int> QuantityProperty = RegisterProperty<int>(c => c.Quantity, "Quantity", 0);
        /// <summary>
        /// Gets and sets the Quantity value
        /// </summary>
        [Display(Name = "Quantity", Description = "")]
        public int Quantity
        {
            get { return GetProperty(QuantityProperty); }
            set { SetProperty(QuantityProperty, value); }
        }

        public static PropertyInfo<int> StockQuantityProperty = RegisterProperty<int>(c => c.StockQuantity, "Stock Quantity", 0);
        /// <summary>
        /// Gets and sets the Stock Quantity value
        /// </summary>
        [Display(Name = "Stock Quantity", Description = "")]
        public int StockQuantity
        {
            get { return GetProperty(StockQuantityProperty); }
            set { SetProperty(StockQuantityProperty, value); }
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
        [Display(Name = "Is Active", Description = "Indicator showing if the Snack is Active"),
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
            return GetProperty(SnackIDProperty);
        }

        public override string ToString()
        {
            if (this.SnackTitle.Length == 0)
            {
                if (this.IsNew)
                {
                    return String.Format("New {0}", "Snack Promo");
                }
                else
                {
                    return String.Format("Blank {0}", "Snack Promo");
                }
            }
            else
            {
                return this.SnackTitle;
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
            // Set any variables here, not in the constructor or NewSnackPromo() method.
        }

        public static SnackPromo NewSnackPromo()
        {
            return DataPortal.CreateChild<SnackPromo>();
        }

        public SnackPromo()
        {
            MarkAsChild();
        }

        internal static SnackPromo GetSnackPromo(SafeDataReader dr)
        {
            var s = new SnackPromo();
            s.Fetch(dr);
            return s;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            using (BypassPropertyChecks)
            {
                int i = 0;
                LoadProperty(SnackIDProperty, sdr.GetInt32(i++));
                LoadProperty(SnackTypeIDProperty, sdr.GetInt32(i++));
                LoadProperty(SnackTitleProperty, sdr.GetString(i++));
                LoadProperty(SnackDescriptionProperty, sdr.GetString(i++));
                LoadProperty(SnackImageURLProperty, sdr.GetString(i++));
                LoadProperty(QuantityProperty, sdr.GetInt32(i++));
                LoadProperty(StockQuantityProperty, sdr.GetInt32(i++));
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

            AddPrimaryKeyParam(cm, SnackIDProperty);

            cm.Parameters.AddWithValue("@SnackTypeID", GetProperty(SnackTypeIDProperty));
            cm.Parameters.AddWithValue("@SnackTitle", GetProperty(SnackTitleProperty));
            cm.Parameters.AddWithValue("@SnackDescription", GetProperty(SnackDescriptionProperty));
            cm.Parameters.AddWithValue("@SnackImageURL", GetProperty(SnackImageURLProperty));
            cm.Parameters.AddWithValue("@Quantity", GetProperty(QuantityProperty));
            cm.Parameters.AddWithValue("@StockQuantity", GetProperty(StockQuantityProperty));
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
                    LoadProperty(SnackIDProperty, scm.Parameters["@SnackID"].Value);
                }
            };
        }

        protected override void SaveChildren()
        {
            // No Children
        }

        protected override void SetupDeleteCommand(SqlCommand cm)
        {
            cm.Parameters.AddWithValue("@SnackID", GetProperty(SnackIDProperty));
        }

        #endregion

    }

}