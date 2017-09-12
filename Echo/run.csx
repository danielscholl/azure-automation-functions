using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage request, TraceWriter log)
{
    object requestBody = await request.Content.ReadAsAsync<object>();
    return request.CreateResponse(HttpStatusCode.OK, requestBody);
}