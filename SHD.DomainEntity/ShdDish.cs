using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace SHD.DomainEntity
{
    [Table("ShdDish")]
    public class ShdDish : FullAuditedEntity<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 创建对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="picPath"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public static ShdDish Create(string name, string picPath, string description)
        {
            return new ShdDish()
            {
                Name = name,
                PicPath = picPath,
                Description = description
            };

        }
    }
}
