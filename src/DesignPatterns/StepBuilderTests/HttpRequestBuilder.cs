namespace DesignPatterns.StepBuilderTests;

public class HttpRequestBuilder : IHttpRequestHeaderBuilder
    , IHttpRequestBodyBuilder
    , IHttpRequestMethodBuilder
    , IHttpRequestGeneratorBuilder
{
    private string _header;
    private string _body;
    private HttpRequestMethods _method;

    public IHttpRequestBodyBuilder Header(string header)
    {
        _header = header;
        return this;
    }

    public IHttpRequestMethodBuilder Body(string body)
    {
        _body = body;
        return this;
    }

    public IHttpRequestGeneratorBuilder Method(HttpRequestMethods method)
    {
        _method = method;
        return this;
    }

    public HttpRequest Build()
    {
        return new HttpRequest(_header, _body, _method);
    }
}

public interface IHttpRequestHeaderBuilder
{
    public IHttpRequestBodyBuilder Header(string header);
}

public interface IHttpRequestBodyBuilder
{
    public IHttpRequestMethodBuilder Body(string body);
}

public interface IHttpRequestMethodBuilder
{
    public IHttpRequestGeneratorBuilder Method(HttpRequestMethods method);
}

public interface IHttpRequestGeneratorBuilder
{
    public HttpRequest Build();
}