using System.Net;

namespace RPSheets.Models.Responses
{
    public interface IResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
