namespace Imtahan.ViewModels.Common
{
    public class PaginationVm<T> where T : IEnumerable<T>
    {
        public PaginationVm(int totalCount, int lastPage, int currentPage,T Item)
        {
            if(totalCount <= 0)
            {
                throw new ArgumentException();
            }
            this.totalCount = totalCount;
            this.lastPage = lastPage;
            this.currentPage = currentPage;
            Items = Item;
            if(lastPage >= currentPage) 
            {
                if(lastPage == 1)
                {
                    HasNext = true; 
                }

                if (currentPage==lastPage)
                    HasPrev = true;
            }
        }

        public int totalCount { get; set; }
        public int lastPage { get; set; }
        public int currentPage { get; set; }

        public bool HasNext { get; set; }
        public bool HasPrev { get; set; }
        public T Items { get; set; }    

    }
}
