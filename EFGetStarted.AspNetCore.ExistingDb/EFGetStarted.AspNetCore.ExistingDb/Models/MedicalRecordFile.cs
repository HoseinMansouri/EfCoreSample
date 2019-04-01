﻿using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class MedicalRecordFile
    {
        public int Id { get; set; }
        public int MedicalId { get; set; }
        public string FileName { get; set; }
        public int FileType { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public MedicalRecord Medical { get; set; }
    }
}
