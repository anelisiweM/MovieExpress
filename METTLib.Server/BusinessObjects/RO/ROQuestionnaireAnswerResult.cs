﻿// Generated 16 Jul 2018 10:27 - Singular Systems Object Generator Version 2.2.694
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


namespace METTLib.RO
{
	[Serializable]
	public class ROQuestionnaireAnswerResult
	 : METTReadOnlyBase<ROQuestionnaireAnswerResult>
	{
		#region " Properties and Methods "

		#region " Properties "

		public static PropertyInfo<int> QuestionnaireAnswerResultIDProperty = RegisterProperty<int>(c => c.QuestionnaireAnswerResultID, "ID", 0);
		/// <summary>
		/// Gets the ID value
		/// </summary>
		[Display(AutoGenerateField = false), Key]
		public int QuestionnaireAnswerResultID
		{
			get { return GetProperty(QuestionnaireAnswerResultIDProperty); }
		}

		public static PropertyInfo<int?> QuestionnaireGroupIDProperty = RegisterProperty<int?>(c => c.QuestionnaireGroupID, "Questionnaire Group", null);
		/// <summary>
		/// Gets the Questionnaire Group value
		/// </summary>
		[Display(Name = "Questionnaire Group ID", Description = "Questionnaire Group ID")]
		public int? QuestionnaireGroupID
		{
			get { return GetProperty(QuestionnaireGroupIDProperty); }
		}

		public static PropertyInfo<int> IndicatorDetailIDProperty = RegisterProperty<int>(c => c.IndicatorDetailID, "Indicator Detail", 0);
		/// <summary>
		/// Gets the Indicator Detail value
		/// </summary>
		[Display(Name = "Indicator Detail", Description = "Indicator Details ID")]
		public int IndicatorDetailID
		{
			get { return GetProperty(IndicatorDetailIDProperty); }
		}

		public static PropertyInfo<String> IndicatorDetailNameProperty = RegisterProperty<String>(c => c.IndicatorDetailName, "Indicator Detail Name", "");
		/// <summary>
		/// Gets the Indicator Detail Name value
		/// </summary>
		[Display(Name = "Indicator Detail Name", Description = "Description of Indicator Details previously referred to as Question Area")]
		public String IndicatorDetailName
		{
			get { return GetProperty(IndicatorDetailNameProperty); }
		}

		public static PropertyInfo<String> CommentsProperty = RegisterProperty<String>(c => c.Comments, "Comments", "");
		/// <summary>
		/// Gets the Comments value
		/// </summary>
		[Display(Name = "Comments", Description = "")]
		public String Comments
		{
			get { return GetProperty(CommentsProperty); }
		}

		public static PropertyInfo<String> NextStepsProperty = RegisterProperty<String>(c => c.NextSteps, "Next Steps", "");
		/// <summary>
		/// Gets the Next Steps value
		/// </summary>
		[Display(Name = "Next Steps", Description = "")]
		public String NextSteps
		{
			get { return GetProperty(NextStepsProperty); }
		}


		public static PropertyInfo<String> EvidenceProperty = RegisterProperty<String>(c => c.Evidence, "Evidence", "");
		/// <summary>
		/// Gets the Evidence value
		/// </summary>
		[Display(Name = "Evidence", Description = "")]
		public String Evidence
		{
			get { return GetProperty(EvidenceProperty); }
		}

		public static PropertyInfo<int> MaxRatingProperty = RegisterProperty<int>(c => c.MaxRating, "Max Rating", 0);
		/// <summary>
		/// Gets the Max Rating value
		/// </summary>
		[Display(Name = "Max Rating", Description = "Maximum rating for the question")]
		public int MaxRating
		{
			get { return GetProperty(MaxRatingProperty); }
		}

		public static PropertyInfo<int> AnswerRatingProperty = RegisterProperty<int>(c => c.AnswerRating, "Answer Rating", -99);
		/// <summary>
		/// Gets the Answer Rating value
		/// </summary>
		[Display(Name = "Answer Rating", Description = "Actual rating for the question")]
		public int AnswerRating
		{
			get { return GetProperty(AnswerRatingProperty); }
		}

		public static PropertyInfo<int> IsCommentsValidProperty = RegisterProperty<int>(c => c.IsCommentsValid, "Is Comments Valid", 0);
		/// <summary>
		/// Gets the Icon value
		/// </summary>
		[Display(Name = "Is Comments Valid", Description = "")]
		public int IsCommentsValid
		{
			get { return GetProperty(IsCommentsValidProperty); }
		}

		public static PropertyInfo<int> IsNextStepsValidProperty = RegisterProperty<int>(c => c.IsNextStepsValid, "Is Next Steps Valid", 0);
		/// <summary>
		/// Gets the Icon value
		/// </summary>
		[Display(Name = "Is Next Steps Valid", Description = "")]
		public int IsNextStepsValid
		{
			get { return GetProperty(IsNextStepsValidProperty); }
		}

		public static PropertyInfo<int> IsEvidenceValidProperty = RegisterProperty<int>(c => c.IsEvidenceValid, "Is Evidence Valid", 0);
		/// <summary>
		/// Gets the Icon value
		/// </summary>
		[Display(Name = "Is Evidence Valid", Description = "")]
		public int IsEvidenceValid
		{
			get { return GetProperty(IsEvidenceValidProperty); }
		}


		#endregion

		#region " Methods "

		protected override object GetIdValue()
		{
			return GetProperty(QuestionnaireAnswerResultIDProperty);
		}

		public override string ToString()
		{
			return this.IndicatorDetailName;
		}

		#endregion

		#endregion

		#region " Data Access & Factory Methods "

		internal static ROQuestionnaireAnswerResult GetROQuestionnaireAnswerResult(SafeDataReader dr)
		{
			var r = new ROQuestionnaireAnswerResult();
			r.Fetch(dr);
			return r;
		}

		protected void Fetch(SafeDataReader sdr)
		{
			int i = 0;
			LoadProperty(QuestionnaireAnswerResultIDProperty, sdr.GetInt32(i++));
			LoadProperty(QuestionnaireGroupIDProperty, Singular.Misc.ZeroNothing(sdr.GetInt32(i++)));
			LoadProperty(IndicatorDetailIDProperty, sdr.GetInt32(i++));
			LoadProperty(IndicatorDetailNameProperty, sdr.GetString(i++));
			try
			{
				LoadProperty(CommentsProperty, sdr.GetString(i++));
				LoadProperty(NextStepsProperty, sdr.GetString(i++));
				LoadProperty(EvidenceProperty, sdr.GetString(i++));
			}
			catch (Exception)
			{

				throw;
			}
		
			LoadProperty(MaxRatingProperty, sdr.GetInt32(i++));
			LoadProperty(AnswerRatingProperty, sdr.GetInt32(i++));

			LoadProperty(IsCommentsValidProperty, sdr.GetInt32(i++));
			LoadProperty(IsNextStepsValidProperty, sdr.GetInt32(i++));
			LoadProperty(IsEvidenceValidProperty, sdr.GetInt32(i++));

		}

		#endregion

	}

}