// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace MgmtTypeSpec
{
    internal partial class PageableWrapper<T, U> : Pageable<U>
    {
        /// <summary> The source pageable value of type Pageable&lt;T&gt;. </summary>
        private Pageable<T> _source;
        /// <summary> The converter function from T to U. </summary>
        private Func<T, U> _converter;

        /// <summary> Initializes a new instance of the PageableWrapper class. </summary>
        /// <param name="source"> The source pageable value of type Pageable&lt;T&gt;. </param>
        /// <param name="converter"> The converter function from T to U. </param>
        public PageableWrapper(Pageable<T> source, Func<T, U> converter)
        {
            _source = source;
            _converter = converter;
        }

        /// <summary> Converts the pages from Pageable to Page. </summary>
        /// <param name="continuationToken"> A continuation token from a previous response. </param>
        /// <param name="pageSizeHint"> An optional hint to specify the desired size of each page. </param>
        /// <returns> An enumerable of pages containing converted items of type U. </returns>
        public override IEnumerable<Page<U>> AsPages(string continuationToken, int? pageSizeHint)
        {
            foreach (Page<T> page in _source.AsPages(continuationToken, pageSizeHint))
            {
                List<U> convertedItems = new List<U>();
                foreach (T item in page.Values)
                {
                    convertedItems.Add(_converter.Invoke(item));
                }
                yield return Page<U>.FromValues(convertedItems, page.ContinuationToken, page.GetRawResponse());
            }
        }
    }
}
