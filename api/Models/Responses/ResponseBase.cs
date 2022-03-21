using System.Net;

namespace RPSheets.Models.Responses
{
    public class ResponseBase : IResponse
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string ErrorMessage { get; set; } = "No error";
    }
}
