using Bunq.Sdk.Context;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Object;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Used to manage text notes.
    /// </summary>
    public class NoteTextPaymentBatch : BunqModel
    {
        /// <summary>
        /// Endpoint constants.
        /// </summary>
        protected const string ENDPOINT_URL_CREATE = "user/{0}/monetary-account/{1}/payment-batch/{2}/note-text";
        protected const string ENDPOINT_URL_UPDATE = "user/{0}/monetary-account/{1}/payment-batch/{2}/note-text/{3}";
        protected const string ENDPOINT_URL_DELETE = "user/{0}/monetary-account/{1}/payment-batch/{2}/note-text/{3}";
        protected const string ENDPOINT_URL_LISTING = "user/{0}/monetary-account/{1}/payment-batch/{2}/note-text";
        protected const string ENDPOINT_URL_READ = "user/{0}/monetary-account/{1}/payment-batch/{2}/note-text/{3}";
    
        /// <summary>
        /// Field constants.
        /// </summary>
        public const string FIELD_CONTENT = "content";
    
        /// <summary>
        /// Object type.
        /// </summary>
        private const string OBJECT_TYPE_GET = "NoteText";
    
        /// <summary>
        /// The content of the note.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    
        /// <summary>
        /// The id of the note.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }
    
        /// <summary>
        /// The timestamp of the note's creation.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }
    
        /// <summary>
        /// The timestamp of the note's last update.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }
    
        /// <summary>
        /// The label of the user who created this note.
        /// </summary>
        [JsonProperty(PropertyName = "label_user_creator")]
        public LabelUser LabelUserCreator { get; set; }
    
    
        /// <summary>
        /// </summary>
        /// <param name="content">The content of the note.</param>
        public static BunqResponse<int> Create(int paymentBatchId, int? monetaryAccountId= null, string content = null, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
    
            var requestMap = new Dictionary<string, object>
    {
    {FIELD_CONTENT, content},
    };
    
            var requestBytes = Encoding.UTF8.GetBytes(BunqJsonConvert.SerializeObject(requestMap));
            var responseRaw = apiClient.Post(string.Format(ENDPOINT_URL_CREATE, DetermineUserId(), DetermineMonetaryAccountId(monetaryAccountId), paymentBatchId), requestBytes, customHeaders);
    
            return ProcessForId(responseRaw);
        }
    
        /// <summary>
        /// </summary>
        /// <param name="content">The content of the note.</param>
        public static BunqResponse<int> Update(int paymentBatchId, int noteTextPaymentBatchId, int? monetaryAccountId= null, string content = null, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
    
            var requestMap = new Dictionary<string, object>
    {
    {FIELD_CONTENT, content},
    };
    
            var requestBytes = Encoding.UTF8.GetBytes(BunqJsonConvert.SerializeObject(requestMap));
            var responseRaw = apiClient.Put(string.Format(ENDPOINT_URL_UPDATE, DetermineUserId(), DetermineMonetaryAccountId(monetaryAccountId), paymentBatchId, noteTextPaymentBatchId), requestBytes, customHeaders);
    
            return ProcessForId(responseRaw);
        }
    
        /// <summary>
        /// </summary>
        public static BunqResponse<object> Delete(int paymentBatchId, int noteTextPaymentBatchId, int? monetaryAccountId= null, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Delete(string.Format(ENDPOINT_URL_DELETE, DetermineUserId(), DetermineMonetaryAccountId(monetaryAccountId), paymentBatchId, noteTextPaymentBatchId), customHeaders);
    
            return new BunqResponse<object>(null, responseRaw.Headers);
        }
    
        /// <summary>
        /// Manage the notes for a given user.
        /// </summary>
        public static BunqResponse<List<NoteTextPaymentBatch>> List(int paymentBatchId, int? monetaryAccountId= null, IDictionary<string, string> urlParams = null, IDictionary<string, string> customHeaders = null)
        {
            if (urlParams == null) urlParams = new Dictionary<string, string>();
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_LISTING, DetermineUserId(), DetermineMonetaryAccountId(monetaryAccountId), paymentBatchId), urlParams, customHeaders);
    
            return FromJsonList<NoteTextPaymentBatch>(responseRaw, OBJECT_TYPE_GET);
        }
    
        /// <summary>
        /// </summary>
        public static BunqResponse<NoteTextPaymentBatch> Get(int paymentBatchId, int noteTextPaymentBatchId, int? monetaryAccountId= null, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_READ, DetermineUserId(), DetermineMonetaryAccountId(monetaryAccountId), paymentBatchId, noteTextPaymentBatchId), new Dictionary<string, string>(), customHeaders);
    
            return FromJson<NoteTextPaymentBatch>(responseRaw, OBJECT_TYPE_GET);
        }
    
    
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
    
            if (this.LabelUserCreator != null)
            {
                return false;
            }
    
            if (this.Content != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static NoteTextPaymentBatch CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<NoteTextPaymentBatch>(json);
        }
    }
}