// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2016 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Models 
{
	public class FindSubdomainParams : ODataObject 
	{

		/// <summary>
		/// Short reprepsetnation of the username
		/// </summary>
		public string UsernameShort { get; set; }

		/// <summary>
		/// User password
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Constrains request to accounts on which the user is an employee.
		/// </summary>
		public bool EmployeeOnly { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as FindSubdomainParams;
			if(typedSource != null)
			{
				UsernameShort = typedSource.UsernameShort;
				Password = typedSource.Password;
				EmployeeOnly = typedSource.EmployeeOnly;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("UsernameShort", out token) && token.Type != JTokenType.Null)
				{
					UsernameShort = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Password", out token) && token.Type != JTokenType.Null)
				{
					Password = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EmployeeOnly", out token) && token.Type != JTokenType.Null)
				{
					EmployeeOnly = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
			}
		}
	}
}