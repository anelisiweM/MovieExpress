﻿// Generated 16 Nov 2021 07:30 - Singular Systems Object Generator Version 2.2.694
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
    public class Account
     : SingularBusinessBase<Account>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> AccountIDProperty = RegisterProperty<int>(c => c.AccountID, "ID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int AccountID
        {
            get { return GetProperty(AccountIDProperty); }
        }

        public static PropertyInfo<int> AccountTypeIDProperty = RegisterProperty<int>(c => c.AccountTypeID, "Account Type", 0);
        /// <summary>
        /// Gets and sets the Account Type value
        /// </summary>
        [Display(Name = "Account Type", Description = ""),
        Required(ErrorMessage = "Account Type required")]
        public int AccountTypeID
        {
            get { return GetProperty(AccountTypeIDProperty); }
            set { SetProperty(AccountTypeIDProperty, value); }
        }

        public static PropertyInfo<int> UserIDProperty = RegisterProperty<int>(c => c.UserID, "User", 0);
        /// <summary>
        /// Gets and sets the User value
        /// </summary>
        [Display(Name = "User", Description = "User's ID account"),
        Required(ErrorMessage = "User required")]
        public int UserID
        {
            get { return GetProperty(UserIDProperty); }
            set { SetProperty(UserIDProperty, value); }
        }

        public static PropertyInfo<Decimal> BalanceProperty = RegisterProperty<Decimal>(c => c.Balance, "Balance", Convert.ToDecimal(0));
        /// <summary>
        /// Gets and sets the Balance value
        /// </summary>
        [Display(Name = "Balance", Description = ""),
        Required(ErrorMessage = "Balance required")]
        public Decimal Balance
        {
            get { return GetProperty(BalanceProperty); }
            set { SetProperty(BalanceProperty, value); }
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
            return GetProperty(AccountIDProperty);
        }

        public override string ToString()
        {
            if (this.CreatedDate.ToString().Length == 0)
            {
                if (this.IsNew)
                {
                    return String.Format("New {0}", "Account");
                }
                else
                {
                    return String.Format("Blank {0}", "Account");
                }
            }
            else
            {
                return this.CreatedDate.ToString();
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
            // Set any variables here, not in the constructor or NewAccount() method.
        }

        public static Account NewAccount()
        {
            return DataPortal.CreateChild<Account>();
        }

        public Account()
        {
            MarkAsChild();
        }

        internal static Account GetAccount(SafeDataReader dr)
        {
            var a = new Account();
            a.Fetch(dr);
            return a;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            using (BypassPropertyChecks)
            {
                int i = 0;
                LoadProperty(AccountIDProperty, sdr.GetInt32(i++));
                LoadProperty(AccountTypeIDProperty, sdr.GetInt32(i++));
                LoadProperty(UserIDProperty, sdr.GetInt32(i++));
                LoadProperty(BalanceProperty, sdr.GetDecimal(i++));
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

            AddPrimaryKeyParam(cm, AccountIDProperty);

            cm.Parameters.AddWithValue("@AccountTypeID", GetProperty(AccountTypeIDProperty));
            cm.Parameters.AddWithValue("@UserID", GetProperty(UserIDProperty));
            cm.Parameters.AddWithValue("@Balance", GetProperty(BalanceProperty));
            cm.Parameters.AddWithValue("@IsActiveInd", GetProperty(IsActiveIndProperty));
            cm.Parameters.AddWithValue("@DeletedDate", Singular.Misc.NothingDBNull(DeletedDate));
            cm.Parameters.AddWithValue("@DeletedBy", GetProperty(DeletedByProperty));
            cm.Parameters.AddWithValue("@ModifiedBy", GetProperty(ModifiedByProperty));

            return (scm) =>
            {
    // Post Save
    if (this.IsNew)
                {
                    LoadProperty(AccountIDProperty, scm.Parameters["@AccountID"].Value);
                }
            };
        }

        protected override void SaveChildren()
        {
            // No Children
        }

        protected override void SetupDeleteCommand(SqlCommand cm)
        {
            cm.Parameters.AddWithValue("@AccountID", GetProperty(AccountIDProperty));
        }

        #endregion

    }

}