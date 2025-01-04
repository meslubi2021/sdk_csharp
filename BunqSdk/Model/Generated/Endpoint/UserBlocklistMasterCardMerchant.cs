using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Fetch blocklists of merchants created by user
    /// </summary>
    public class UserBlocklistMasterCardMerchant : BunqModel
    {
        /// <summary>
        /// Field constants.
        /// </summary>
        public const string FIELD_MERCHANT_NAME = "merchant_name";
        public const string FIELD_MERCHANT_ID = "merchant_id";
        public const string FIELD_MERCHANT_IDENTIFIER = "merchant_identifier";
        public const string FIELD_MASTERCARD_MERCHANT_ID = "mastercard_merchant_id";
        public const string FIELD_EXTERNAL_MERCHANT_ID = "external_merchant_id";
    
    
        /// <summary>
        /// The name of the merchant.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_name")]
        public string MerchantName { get; set; }
        /// <summary>
        /// The blocklisted merchant.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_id")]
        public string MerchantId { get; set; }
        /// <summary>
        /// Identifier of the merchant we are blocklisting.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_identifier")]
        public string MerchantIdentifier { get; set; }
        /// <summary>
        /// The blocklisted merchant.
        /// </summary>
        [JsonProperty(PropertyName = "mastercard_merchant_id")]
        public string MastercardMerchantId { get; set; }
        /// <summary>
        /// Externally provided merchant identification.
        /// </summary>
        [JsonProperty(PropertyName = "external_merchant_id")]
        public string ExternalMerchantId { get; set; }
        /// <summary>
        /// The id of the blocklist.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }
        /// <summary>
        /// The timestamp of the object's creation.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }
        /// <summary>
        /// The timestamp of the object's last update.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }
        /// <summary>
        /// The status of the the blocklist.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        /// <summary>
        /// Hash of the merchant we are blocklisting.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_hash")]
        public string MerchantHash { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "merchant_avatar")]
        public Avatar MerchantAvatar { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Id != null)
            {
                return false;
            }
    
            if (this.Created != null)
            {
                return false;
            }
    
            if (this.Updated != null)
            {
                return false;
            }
    
            if (this.Status != null)
            {
                return false;
            }
    
            if (this.MerchantName != null)
            {
                return false;
            }
    
            if (this.MerchantId != null)
            {
                return false;
            }
    
            if (this.MerchantIdentifier != null)
            {
                return false;
            }
    
            if (this.MastercardMerchantId != null)
            {
                return false;
            }
    
            if (this.ExternalMerchantId != null)
            {
                return false;
            }
    
            if (this.MerchantHash != null)
            {
                return false;
            }
    
            if (this.MerchantAvatar != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static UserBlocklistMasterCardMerchant CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<UserBlocklistMasterCardMerchant>(json);
        }
    }
}
