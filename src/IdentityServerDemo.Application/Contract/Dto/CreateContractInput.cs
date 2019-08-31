using System;
using Abp.AutoMapper;

namespace IS.Contracts.Dto
{
    //[AutoMap(typeof(Contract))]
    public class CreateContractInput
    {
        public bool IsActive { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public long ClientId { get; set; }

        public long CandidateId { get; set; }

        public bool Signed { get; set; }

        public DateTime CreationTime { get; set; }
    }
}