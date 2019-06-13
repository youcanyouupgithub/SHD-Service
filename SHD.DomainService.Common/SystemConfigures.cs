using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHD.DomainService.Common
{
    [Table("SystemConfigures")]
    public class SystemConfigures : FullAuditedEntity<int>
    {
        /// <summary>
        /// 公共服务应用(https://jira.mingyuanyun.com/browse/YFXT-2135)
        /// </summary>
        public const string CommonServiceKey = "CommonService";

        /// <summary>
        /// 平台服务应用(https://jira.mingyuanyun.com/browse/YFXT-2137)
        /// </summary>
        public const string PlatformServiceKey = "PlatformService";

        [Required]
        [StringLength(32)]
        public string Key { get; set; }

        [Required]
        [StringLength(32)]
        public string Value { get; set; }
    }
}
