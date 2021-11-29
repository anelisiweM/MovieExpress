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
    public class NewUser
     : SingularBusinessBase<NewUser>
    {
        #region " Properties and Methods "

        #region " Properties "

        public static PropertyInfo<int> UserIDProperty = RegisterProperty<int>(c => c.UserID, "ID", 0);
        /// <summary>
        /// Gets the ID value
        /// </summary>
        [Display(AutoGenerateField = false), Key]
        public int UserID
        {
            get { return GetProperty(UserIDProperty); }
        }

        public static PropertyInfo<byte[]> FirstNameProperty = RegisterProperty<byte[]>(c => c.FirstName, "First Name", null);
        /// <summary>
        /// Gets and sets the First Name value
        /// </summary>
        [Display(Name = "First Name", Description = ""),
        Required(ErrorMessage = "First Name required")]
        public byte[] FirstName
        {
            get { return GetProperty(FirstNameProperty); }
            set { SetProperty(FirstNameProperty, value); }
        }

        public static PropertyInfo<byte[]> LastNameProperty = RegisterProperty<byte[]>(c => c.LastName, "Last Name", null);
        /// <summary>
        /// Gets and sets the Last Name value
        /// </summary>
        [Display(Name = "Last Name", Description = ""),
        Required(ErrorMessage = "Last Name required")]
        public byte[] LastName
        {
            get { return GetProperty(LastNameProperty); }
            set { SetProperty(LastNameProperty, value); }
        }

        public static PropertyInfo<String> UserNameProperty = RegisterProperty<String>(c => c.UserName, "User Name", "");
        /// <summary>
        /// Gets and sets the User Name value
        /// </summary>
        [Display(Name = "User Name", Description = ""),
        StringLength(50, ErrorMessage = "User Name cannot be more than 50 characters")]
        public String UserName
        {
            get { return GetProperty(UserNameProperty); }
            set { SetProperty(UserNameProperty, value); }
        }

        public static PropertyInfo<byte[]> PasswordProperty = RegisterProperty<byte[]>(c => c.Password, "Password", null);
        /// <summary>
        /// Gets and sets the Password value
        /// </summary>
        [Display(Name = "Password", Description = "SHA2_256 hashed password."),
        Required(ErrorMessage = "Password required")]
        public byte[] Password
        {
            get { return GetProperty(PasswordProperty); }
            set { SetProperty(PasswordProperty, value); }
        }

        public static PropertyInfo<byte[]> SaltProperty = RegisterProperty<byte[]>(c => c.Salt, "Salt");
        /// <summary>
        /// Gets and sets the Salt value
        /// </summary>
        [Display(Name = "Salt", Description = "Salt to be combined with plain text password. This is a guid that is changed whenever the user changes their password."),
        Required(ErrorMessage = "Salt required")]
        public byte[] Salt
        {
            get { return GetProperty(SaltProperty); }
            set { SetProperty(SaltProperty, value); }
        }

        public static PropertyInfo<DateTime> PasswordChangeDateProperty = RegisterProperty<DateTime>(c => c.PasswordChangeDate, "Password Change Date");
        /// <summary>
        /// Gets and sets the Password Change Date value
        /// </summary>
        [Display(Name = "Password Change Date", Description = "Last time the password was changed / when the user was created."),
        Required(ErrorMessage = "Password Change Date required")]
        public DateTime PasswordChangeDate
        {
            get
            {
                return GetProperty(PasswordChangeDateProperty);
            }
            set
            {
                SetProperty(PasswordChangeDateProperty, value);
            }
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
        public int? CreatedBy
        {
            get { return GetProperty(CreatedByProperty); }
        }

        public static PropertyInfo<Boolean> FirstTimeLoginProperty = RegisterProperty<Boolean>(c => c.FirstTimeLogin, "First Time Login", true);
        /// <summary>
        /// Gets and sets the First Time Login value
        /// </summary>
        [Display(Name = "First Time Login", Description = "True when the user is created, set to false the first time they log in."),
        Required(ErrorMessage = "First Time Login required")]
        public Boolean FirstTimeLogin
        {
            get { return GetProperty(FirstTimeLoginProperty); }
            set { SetProperty(FirstTimeLoginProperty, value); }
        }

        public static PropertyInfo<String> EmailAddressProperty = RegisterProperty<String>(c => c.EmailAddress, "Email Address", "");
        /// <summary>
        /// Gets and sets the Email Address value
        /// </summary>
        [Display(Name = "Email Address", Description = "The user’s email address. The user will use this to login into the system as well as to receive any communications sent by the system."),
        StringLength(100, ErrorMessage = "Email Address cannot be more than 100 characters")]
        public String EmailAddress
        {
            get { return GetProperty(EmailAddressProperty); }
            set { SetProperty(EmailAddressProperty, value); }
        }

        public static PropertyInfo<int> ResetStateProperty = RegisterProperty<int>(c => c.ResetState, "Reset State", 1);
        /// <summary>
        /// Gets and sets the Reset State value
        /// </summary>
        [Display(Name = "Reset State", Description = "Password reset state. 0 = Normal, 1=Must change password on login, 2=Locked out until password reset again."),
        Required(ErrorMessage = "Reset State required")]
        public int ResetState
        {
            get { return GetProperty(ResetStateProperty); }
            set { SetProperty(ResetStateProperty, value); }
        }

        public static PropertyInfo<String> ContactNumberProperty = RegisterProperty<String>(c => c.ContactNumber, "Contact Number", "");
        /// <summary>
        /// Gets and sets the Contact Number value
        /// </summary>
        [Display(Name = "Contact Number", Description = "The user’s main contact number"),
        StringLength(50, ErrorMessage = "Contact Number cannot be more than 50 characters")]
        public String ContactNumber
        {
            get { return GetProperty(ContactNumberProperty); }
            set { SetProperty(ContactNumberProperty, value); }
        }

        public static PropertyInfo<int> JobDescriptionIDProperty = RegisterProperty<int>(c => c.JobDescriptionID, "Job Description", 0);
        /// <summary>
        /// Gets and sets the Job Description value
        /// </summary>
        [Display(Name = "Job Description", Description = "The user’s general job description")]
        public int JobDescriptionID
        {
            get { return GetProperty(JobDescriptionIDProperty); }
            set { SetProperty(JobDescriptionIDProperty, value); }
        }

        public static PropertyInfo<Boolean> DeletedIndProperty = RegisterProperty<Boolean>(c => c.DeletedInd, "Deleted", false);
        /// <summary>
        /// Gets and sets the Deleted value
        /// </summary>
        [Display(Name = "Deleted", Description = ""),
        Required(ErrorMessage = "Deleted required")]
        public Boolean DeletedInd
        {
            get { return GetProperty(DeletedIndProperty); }
            set { SetProperty(DeletedIndProperty, value); }
        }

        public static PropertyInfo<String> JobDescriptionProperty = RegisterProperty<String>(c => c.JobDescription, "Job Description", "");
        /// <summary>
        /// Gets and sets the Job Description value
        /// </summary>
        [Display(Name = "Job Description", Description = ""),
        StringLength(100, ErrorMessage = "Job Description cannot be more than 100 characters")]
        public String JobDescription
        {
            get { return GetProperty(JobDescriptionProperty); }
            set { SetProperty(JobDescriptionProperty, value); }
        }

        public static PropertyInfo<String> PictureProperty = RegisterProperty<String>(c => c.Picture, "Picture", "");
        /// <summary>
        /// Gets and sets the Picture value
        /// </summary>
        [Display(Name = "Picture", Description = "")]
        public String Picture
        {
            get { return GetProperty(PictureProperty); }
            set { SetProperty(PictureProperty, value); }
        }

        #endregion

        #region " Methods "

        protected override object GetIdValue()
        {
            return GetProperty(UserIDProperty);
        }

        public override string ToString()
        {
            if (this.UserName.Length == 0)
            {
                if (this.IsNew)
                {
                    return String.Format("New {0}", "New User");
                }
                else
                {
                    return String.Format("Blank {0}", "New User");
                }
            }
            else
            {
                return this.UserName;
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
            // Set any variables here, not in the constructor or NewNewUser() method.
        }

        public static NewUser NewNewUser()
        {
            return DataPortal.CreateChild<NewUser>();
        }

        public NewUser()
        {
            MarkAsChild();
        }

        internal static NewUser GetNewUser(SafeDataReader dr)
        {
            var n = new NewUser();
            n.Fetch(dr);
            return n;
        }

        protected void Fetch(SafeDataReader sdr)
        {
            using (BypassPropertyChecks)
            {
                int i = 0;
                LoadProperty(UserIDProperty, sdr.GetInt32(i++));
                LoadProperty(FirstNameProperty, sdr.GetValue(i++));
                LoadProperty(LastNameProperty, sdr.GetValue(i++));
                LoadProperty(UserNameProperty, sdr.GetString(i++));
                LoadProperty(PasswordProperty, sdr.GetValue(i++));
                LoadProperty(SaltProperty, sdr.GetValue(i++));
                LoadProperty(PasswordChangeDateProperty, sdr.GetValue(i++));
                LoadProperty(CreatedDateProperty, sdr.GetSmartDate(i++));
                LoadProperty(CreatedByProperty, sdr.GetInt32(i++));
                LoadProperty(FirstTimeLoginProperty, sdr.GetBoolean(i++));
                LoadProperty(EmailAddressProperty, sdr.GetString(i++));
                LoadProperty(ResetStateProperty, sdr.GetInt32(i++));
                LoadProperty(ContactNumberProperty, sdr.GetString(i++));
                LoadProperty(JobDescriptionIDProperty, sdr.GetInt32(i++));
                LoadProperty(DeletedIndProperty, sdr.GetBoolean(i++));
                LoadProperty(JobDescriptionProperty, sdr.GetString(i++));
                LoadProperty(PictureProperty, sdr.GetString(i++));
            }

            MarkAsChild();
            MarkOld();
            BusinessRules.CheckRules();
        }

        protected override Action<SqlCommand> SetupSaveCommand(SqlCommand cm)
        {
            if (this.IsNew)
            {
                LoadProperty(CreatedByProperty, Settings.CurrentUser.UserID);
            }

            AddPrimaryKeyParam(cm, UserIDProperty);

            cm.Parameters.AddWithValue("@FirstName", GetProperty(FirstNameProperty));
            cm.Parameters.AddWithValue("@LastName", GetProperty(LastNameProperty));
            cm.Parameters.AddWithValue("@UserName", GetProperty(UserNameProperty));
            cm.Parameters.AddWithValue("@Password", GetProperty(PasswordProperty));
            cm.Parameters.AddWithValue("@Salt", GetProperty(SaltProperty));
            cm.Parameters.AddWithValue("@PasswordChangeDate", PasswordChangeDate);
            cm.Parameters.AddWithValue("@CreatedBy", GetProperty(CreatedByProperty));
            cm.Parameters.AddWithValue("@FirstTimeLogin", GetProperty(FirstTimeLoginProperty));
            cm.Parameters.AddWithValue("@EmailAddress", GetProperty(EmailAddressProperty));
            cm.Parameters.AddWithValue("@ResetState", GetProperty(ResetStateProperty));
            cm.Parameters.AddWithValue("@ContactNumber", GetProperty(ContactNumberProperty));
            cm.Parameters.AddWithValue("@JobDescriptionID", GetProperty(JobDescriptionIDProperty));
            cm.Parameters.AddWithValue("@DeletedInd", GetProperty(DeletedIndProperty));
            cm.Parameters.AddWithValue("@JobDescription", GetProperty(JobDescriptionProperty));
            cm.Parameters.AddWithValue("@Picture", GetProperty(PictureProperty));

            return (scm) =>
            {
    // Post Save
    if (this.IsNew)
                {
                    LoadProperty(UserIDProperty, scm.Parameters["@UserID"].Value);
                }
            };
        }

        protected override void SaveChildren()
        {
            // No Children
        }

        protected override void SetupDeleteCommand(SqlCommand cm)
        {
            cm.Parameters.AddWithValue("@UserID", GetProperty(UserIDProperty));
        }

        #endregion

    }

}