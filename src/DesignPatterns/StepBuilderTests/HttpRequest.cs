namespace DesignPatterns.StepBuilderTests;

public class HttpRequest
{
    public  readonly string Header;
    public  readonly string Body;
    public  readonly HttpRequestMethods Method;

    public HttpRequest(string header, string body, HttpRequestMethods method)
    {
        Header = header;
        Body = body;
        Method = method;
    }
}