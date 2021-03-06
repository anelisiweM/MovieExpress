// Generated 21 Oct 2021 15:49 - Singular Systems Object Generator Version 2.2.694
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


namespace MELib.AccountTypes
{
    [Serializable]
    public class AccountType
     : SingularBusinessBase<AccountType>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> AccountTypeIDProperty = RegisterProperty<int>(c => c.AccountTypeID, "ID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int AccountTypeID
        {
            get { return GetProperty(AccountTypeIDProperty); }
        }

        public static PropertyInfo<String> AccountTypeProperty = RegisterProperty<String>(c => c.AccountTypeName, "Account Type", "");
        /// <summary>
        /// Gets and sets the Account Type value
        /// </summary>
        [Display(Name = "Account Type", Description = ""),
        StringLength(50, ErrorMessage = "Account Type cannot be more than 50 characters")]
        public String AccountTypeName
        {
            get { return GetProperty(AccountTypeProperty); }
            set { SetProperty(AccountTypeProperty, value); }
        }

        public static PropertyInfo<String> AccountTypeCodeProperty = RegisterProperty<String>(c => c.AccountTypeCode, "Account Type Code", "");
        /// <summary>
        /// Gets and sets the Account Type Code value
        /// </summary>
        [Display(Name = "Account Type Code", Description = ""),
        StringLength(50, ErrorMessage = "Account Type Code cannot be more than 50 characters")]
        public String AccountTypeCode
        {
            get { return GetProperty(AccountTypeCodeProperty); }
            set { SetProperty(AccountTypeCodeProperty, value); }
        }

        public static PropertyInfo<Boolean> IsActiveIndProperty = RegisterProperty<Boolean>(c => c.IsActiveInd, "Is Active", true);
        /// <summary>
        /// Gets and sets the Is Active value
        /// </summary>
        [Display(Name = "Is Active", Description = "Indicator showing if the Movie is Active"),
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
            return GetProperty(AccountTypeIDProperty);
        }

        public override string ToString()
        {
            if (this.AccountTypeName.Length == 0)
            {
                if (this.IsNew)
                {
                    return String.Format("New {0}", "Account Type");
                }
                else
                {
                    return String.Format("Blank {0}", "Account Type");
                }
            }
            else
            {
                return this.AccountTypeName;
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
            // Set any variables here, not in the constructor or NewAccountType() method.
        }

        public static AccountType NewAccountType()
        {
            return DataPortal.CreateChild<AccountType>();
        }

        public AccountType()
        {
            MarkAsChild();
        }

        internal static AccountType GetAccountType(SafeDataReader dr)
        {
            var a = new AccountType();
            a.Fetch(dr);
            return a;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            using (BypassPropertyChecks)
            {
                int i = 0;
                LoadProperty(AccountTypeIDProperty, sdr.GetInt32(i++));
                LoadProperty(AccountTypeProperty, sdr.GetString(i++));
                LoadProperty(AccountTypeCodeProperty, sdr.GetString(i++));
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

            AddPrimaryKeyParam(cm, AccountTypeIDProperty);

            cm.Parameters.AddWithValue("@AccountType", GetProperty(AccountTypeProperty));
            cm.Parameters.AddWithValue("@AccountTypeCode", GetProperty(AccountTypeCodeProperty));
            cm.Parameters.AddWithValue("@IsActiveInd", GetProperty(IsActiveIndProperty));
            cm.Parameters.AddWithValue("@DeletedDate", Singular.Misc.NothingDBNull(DeletedDate));
            cm.Parameters.AddWithValue("@DeletedBy", GetProperty(DeletedByProperty));
            cm.Parameters.AddWithValue("@ModifiedBy", GetProperty(ModifiedByProperty));

            return (scm) =>
            {
    // Post Save
    if (this.IsNew)
                {
                    LoadProperty(AccountTypeIDProperty, scm.Parameters["@AccountTypeID"].Value);
                }
            };
        }

        protected override void SaveChildren()
        {
            // No Children
        }

        protected override void SetupDeleteCommand(SqlCommand cm)
        {
            cm.Parameters.AddWithValue("@AccountTypeID", GetProperty(AccountTypeIDProperty));
        }

        #endregion

    }

}