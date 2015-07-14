using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    /// <summary>
    /// This class is used to send Json response back when calling save/delete
    /// </summary>
    public class JsonResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public NameValueCollection AdditionalInfo { get; set; }
        public string CreatedId { get; set; }

        public JsonResponse(string message, bool success)
        {
            Message = message;
            Success = success;
            AdditionalInfo = null;
        }

        public JsonResponse(string message, bool success, string createdId)
        {
            Message = message;
            Success = success;
            CreatedId = createdId;
        }

        public JsonResponse( string message, bool success,NameValueCollection additionalInfo)
        {
            AdditionalInfo = additionalInfo;
            Message = message;
            Success = success;
        }
    }
}
