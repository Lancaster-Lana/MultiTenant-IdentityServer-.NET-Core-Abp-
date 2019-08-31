using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace IS.Contracts.Dto
{
    //[AutoMapFrom(typeof(Contract))]
    public class ContractListDto : EntityDto<long>
    {
        public bool IsActive { get; set; }

        public bool IsSigned { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public long ClientId { get; set; }

        public long CandidateId { get; set; }

        public bool Signed { get; set; }

        public DateTime CreationTime { get; set; }
    }
}