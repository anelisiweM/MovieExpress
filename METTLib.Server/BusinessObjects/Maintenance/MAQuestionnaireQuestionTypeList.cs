﻿// Generated 02 Oct 2018 11:29 - Singular Systems Object Generator Version 2.2.694
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


namespace METTLib.Maintenance
{
	[Serializable]
	public class MAQuestionnaireQuestionTypeList
	 : METTBusinessListBase<MAQuestionnaireQuestionTypeList, MAQuestionnaireQuestionType>
	{
		#region " Business Methods "

		public MAQuestionnaireQuestionType GetItem(int QuestionnaireQuestionTypeID)
		{
			foreach (MAQuestionnaireQuestionType child in this)
			{
				if (child.QuestionnaireQuestionTypeID == QuestionnaireQuestionTypeID)
				{
					return child;
				}
			}
			return null;
		}

		public override string ToString()
		{
			return "Questionnaire Question Types";
		}

		#endregion

		#region " Data Access "

		public static MAQuestionnaireQuestionTypeList NewMAQuestionnaireQuestionTypeList()
		{
			return new MAQuestionnaireQuestionTypeList();
		}

		public MAQuestionnaireQuestionTypeList()
		{
			// must have parameter-less constructor
		}

		#endregion

	}

}