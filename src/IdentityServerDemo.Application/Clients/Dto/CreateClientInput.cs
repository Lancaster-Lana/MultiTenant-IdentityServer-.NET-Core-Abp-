using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using IS.Authorization.Users;

namespace IS.Clients.Dto
{
    //[AutoMap(typeof(Client))]
    public class CreateClientInput
    {
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [StringLength(User.MaxNameLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(User.MaxSurnameLength)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(User.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}