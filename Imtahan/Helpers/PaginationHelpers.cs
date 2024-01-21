namespace Imtahan.Helpers
{
    public static class PaginationHelpers
    {
        

        public static IQueryable<T> Pagination<T>(T query,int totalCount,int page = 1,int count = 4) where T : IQueryable<T> 
        {
            return query.Skip((page-1)*count).Take(count);
        } 
    }
}
