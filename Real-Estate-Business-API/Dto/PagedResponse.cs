﻿namespace Real_Estate_Business_API.Dto
{
    public class PagedResponse<T>
    {
        public List<T> Items { get; }
        public int PageIndex { get; }
        public int TotalPages { get; }
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        public PagedResponse(List<T> items, int pageIndex, int totalPages)
        {
            Items = items;
            PageIndex = pageIndex;
            TotalPages = totalPages;
        }
    }
}
