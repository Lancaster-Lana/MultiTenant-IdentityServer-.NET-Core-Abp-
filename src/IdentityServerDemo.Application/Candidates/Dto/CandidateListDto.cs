using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace IS.Candidates.Dto
{
    //[AutoMapFrom(typeof(Candidate))]
    public class CandidateListDto : EntityDto<long>
    {
        public bool IsActive { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime CreationTime { get; set; }
    }
}