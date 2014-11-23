using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    [Serializable]
    public abstract class Entity
    {
        protected Entity()
        {
            this.SortId = 0;
            this.IsDeleted = false;
            this.CreatedTime = DateTime.Now;
            this.CreatedBy = "System";
        }

        /// <summary>
        /// 数据的排序Id
        /// </summary>
        public int SortId { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        [StringLength(32)]
        public string Remark { get; set; }

        /// <summary>
        /// 获取或设置是否禁用，逻辑上的删除，非物理删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DataType(DataType.DateTime)]
        public Nullable<DateTime> CreatedTime { get; set; }

        /// <summary>
        /// 获取或设置 创建人员
        /// </summary>
        [StringLength(32)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 获取或设置 修改时间
        /// </summary>
        [DataType(DataType.DateTime)]
        public Nullable<DateTime> UpdatedTime { get; set; }

        /// <summary>
        /// 获取或设置 修改人员
        /// </summary>
        [StringLength(32)]
        public string UpdatedBy { get; set; }


        /// <summary>
        /// 获取或设置 版本控制标识，用于处理并发
        /// </summary>
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
