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
	public class Cancellation : ODataObject 
	{
		public string Password { get; set; }
		public string Reason { get; set; }
		public int? ReasonCode { get; set; }
		public bool? AutoEmail { get; set; }
		public bool? CancelAddOns { get; set; }
		public string InternalNotes { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as Cancellation;
			if(typedSource != null)
			{
				Password = typedSource.Password;
				Reason = typedSource.Reason;
				ReasonCode = typedSource.ReasonCode;
				AutoEmail = typedSource.AutoEmail;
				CancelAddOns = typedSource.CancelAddOns;
				InternalNotes = typedSource.InternalNotes;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Password", out token) && token.Type != JTokenType.Null)
				{
					Password = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Reason", out token) && token.Type != JTokenType.Null)
				{
					Reason = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ReasonCode", out token) && token.Type != JTokenType.Null)
				{
					ReasonCode = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("AutoEmail", out token) && token.Type != JTokenType.Null)
				{
					AutoEmail = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CancelAddOns", out token) && token.Type != JTokenType.Null)
				{
					CancelAddOns = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("InternalNotes", out token) && token.Type != JTokenType.Null)
				{
					InternalNotes = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}