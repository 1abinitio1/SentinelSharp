using System.Collections;
using System.Collections.Generic;

namespace SentinelSharp
{
    public class ProductInfo
    {
        public string PreviewLink;
        public string FullDataLink;
        public string Id;

        public byte[] DownloadPreviewData(SentinelSearch sentinelSearch)
        {
            return sentinelSearch.WebClient.DownloadData(PreviewLink);

        }
    }
}