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
using ShareFile.Api.Client;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Models;
using ShareFile.Api.Client.Requests;


namespace ShareFile.Api.Client.Entities
{
    public interface IWebhookClientsEntity : IEntityBase
    {
        
        /// <summary>
        /// Gets the configuration settings for a webhook client
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// WebhookClient
        /// </returns>
        IQuery<WebhookClient> Get(Uri url);
        
        /// <summary>
        /// Generates a new primary signature key for the webhook client
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// WebhookClient
        /// </returns>
        IQuery<WebhookClient> GeneratePrimarySignatureKey(Uri url);
        
        /// <summary>
        /// Generates a new secondary signature key for the webhook client
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// WebhookClient
        /// </returns>
        IQuery<WebhookClient> GenerateSecondarySignatureKey(Uri url);
    }

    public class WebhookClientsEntity : EntityBase, IWebhookClientsEntity
    {
        public WebhookClientsEntity (IShareFileClient client)
            : base (client, "WebhookClients")
        { }
        
        
        /// <summary>
        /// Gets the configuration settings for a webhook client
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// WebhookClient
        /// </returns>
        public IQuery<WebhookClient> Get(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<WebhookClient>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
            return sfApiQuery;
        }
        
        /// <summary>
        /// Generates a new primary signature key for the webhook client
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// WebhookClient
        /// </returns>
        public IQuery<WebhookClient> GeneratePrimarySignatureKey(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<WebhookClient>(Client);
            sfApiQuery.Action("PrimarySignatureKey");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "POST";	
            return sfApiQuery;
        }
        
        /// <summary>
        /// Generates a new secondary signature key for the webhook client
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// WebhookClient
        /// </returns>
        public IQuery<WebhookClient> GenerateSecondarySignatureKey(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<WebhookClient>(Client);
            sfApiQuery.Action("SecondarySignatureKey");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "POST";	
            return sfApiQuery;
        }
    }
}