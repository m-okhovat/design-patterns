using DesignPatterns.StepBuilderTests;

namespace SpecificationRTests.StepBuilderTests;

public class HttpRequestBuilderTests
{
    [Fact]
    public void Create_http_request()
    {
        const string someHeader = "some header";
        const string someBody = "some body";
        const HttpRequestMethods method = HttpRequestMethods.POST;
        
        var request = HttpRequestFactory
            .Instance()
            .Header(someHeader)
            .Body(someBody)
            .Method(method)
            .Build();
        
        Assert.Equal(someHeader, request.Header);
        Assert.Equal(someBody, request.Body);
        Assert.Equal(method, request.Method);

    }
}

