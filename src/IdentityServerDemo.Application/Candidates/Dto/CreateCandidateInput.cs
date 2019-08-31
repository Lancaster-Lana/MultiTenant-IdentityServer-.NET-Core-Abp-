using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;

namespace IS.Candidates.Dto
{
    //[AutoMap(typeof(Candidate))]
    public class CreateCandidateInput
    {
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        //[StringLength(User.MaxNameLength)]
        public string FirstName { get; set; }

        [Required]
       // [StringLength(User.MaxSurnameLength)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [Required]
        //[StringLength(User.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}