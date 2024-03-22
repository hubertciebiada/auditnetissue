using Audit.WebApi;

namespace AuditNetIssue.MyAudit;

public static class MyAudit
{
    public static IApplicationBuilder UseMyAudit(this IApplicationBuilder webApplication)
    {
        return webApplication.UseAuditMiddleware(x => x
            .IncludeResponseHeaders()
            .IncludeResponseBody()
            .IncludeRequestBody());
    }
}