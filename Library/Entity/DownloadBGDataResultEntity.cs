﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace iHealthlabs.OpenAPI.Sample.Library.Entity
{
    [DataContract]
    public class DownloadBGDataResultEntity
    {
        public DownloadBGDataResultEntity() { }
        /// <summary>
        /// The page data
        /// </summary>
        [DataMember]
        public List<DownloadBGDataEntity> BGDataList { get; set; }
        /// <summary>
        /// 2013 5 15 Blood  glucose  units mgdl  mmoll
        /// </summary>
        [DataMember]
        public int BGUnit { get; set; }
        /// <summary>
        /// Current Total
        /// </summary>
        [DataMember]
        public int CurrentRecordCount { get; set; }
        /// <summary>
        /// Next page URL
        /// </summary>
        [DataMember]
        public string NextPageUrl { get; set; }
        /// <summary>
        /// Page number
        /// </summary>
        [DataMember]
        public int PageLength { get; set; }
        /// <summary>
        /// Current page
        /// </summary>
        [DataMember]
        public int PageNumber { get; set; }
        /// <summary>
        /// Page up URL
        /// </summary>
        [DataMember]
        public string PrevPageUrl { get; set; }
        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        public int RecordCount { get; set; }
    }
}
