// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.CmsKit.Contents;
using Volo.CmsKit.Users;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Public.Blogs.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IBlogPostPublicAppService), typeof(BlogPostPublicClientProxy))]
public partial class BlogPostPublicClientProxy : ClientProxyBase<IBlogPostPublicAppService>, IBlogPostPublicAppService
{
    public virtual async Task<BlogPostCommonDto> GetAsync(string blogSlug, string blogPostSlug)
    {
        return await RequestAsync<BlogPostCommonDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), blogSlug },
            { typeof(string), blogPostSlug }
        });
    }

    public virtual async Task<PagedResultDto<BlogPostCommonDto>> GetListAsync(string blogSlug, BlogPostGetListInput input)
    {
        return await RequestAsync<PagedResultDto<BlogPostCommonDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), blogSlug },
            { typeof(BlogPostGetListInput), input }
        });
    }

    public virtual async Task<PagedResultDto<CmsUserDto>> GetAuthorsHasBlogPostsAsync(BlogPostFilteredPagedAndSortedResultRequestDto input)
    {
        return await RequestAsync<PagedResultDto<CmsUserDto>>(nameof(GetAuthorsHasBlogPostsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(BlogPostFilteredPagedAndSortedResultRequestDto), input }
        });
    }

    public virtual async Task<CmsUserDto> GetAuthorHasBlogPostAsync(Guid id)
    {
        return await RequestAsync<CmsUserDto>(nameof(GetAuthorHasBlogPostAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}
