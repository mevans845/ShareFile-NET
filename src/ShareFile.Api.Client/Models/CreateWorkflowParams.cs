// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
#if !ShareFile
	/// <summary>
	/// Defines a request to create a Workflow.
	/// </summary>
	public class CreateWorkflowParams : ODataObject 
	{
		/// <summary>
		/// List of Participants for the workflow.
		/// </summary>
		public IEnumerable<WorkflowParticipant> Participants { get; set; }
		/// <summary>
		/// Optional message to be included to contact.
		/// </summary>
		public string Message { get; set; }
		public DateTime Due { get; set; }
		/// <summary>
		/// Enforce approval order. If true, then participant ordinals must be in sequential order
		/// </summary>
		public bool IsSequenced { get; set; }
		/// <summary>
		/// If true, then every approver must re-approve newly uploaded versions.
		/// </summary>
		public bool RestartOnNewVersion { get; set; }
		/// <summary>
		/// Determines if the server will email the workflow links or not.
		/// If using , then will be populated on the result.
		/// For Feedback workflows, if set to , then participants are not accepted.For Approval workflows, participants are required for both distribution methods.
		/// </summary>
		public SafeEnum<DistributionMethod> DistributionMethod { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as CreateWorkflowParams;
			if(typedSource != null)
			{
				Participants = typedSource.Participants;
				Message = typedSource.Message;
				Due = typedSource.Due;
				IsSequenced = typedSource.IsSequenced;
				RestartOnNewVersion = typedSource.RestartOnNewVersion;
				DistributionMethod = typedSource.DistributionMethod;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Participants", out token) && token.Type != JTokenType.Null)
				{
					Participants = (IEnumerable<WorkflowParticipant>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<WorkflowParticipant>));
				}
				if(source.TryGetProperty("Message", out token) && token.Type != JTokenType.Null)
				{
					Message = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Due", out token) && token.Type != JTokenType.Null)
				{
					Due = (DateTime)serializer.Deserialize(token.CreateReader(), typeof(DateTime));
				}
				if(source.TryGetProperty("IsSequenced", out token) && token.Type != JTokenType.Null)
				{
					IsSequenced = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("RestartOnNewVersion", out token) && token.Type != JTokenType.Null)
				{
					RestartOnNewVersion = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("DistributionMethod", out token) && token.Type != JTokenType.Null)
				{
					DistributionMethod = (SafeEnum<DistributionMethod>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<DistributionMethod>));
				}
			}
		}
	}
#endif
}