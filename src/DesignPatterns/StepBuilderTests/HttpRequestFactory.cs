namespace DesignPatterns.StepBuilderTests;

public static class HttpRequestFactory
{
    public static IHttpRequestHeaderBuilder Instance()
    {
        return new HttpRequestBuilder();
    }
}