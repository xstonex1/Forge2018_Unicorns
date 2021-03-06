﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.DTO
{
    public class LoanSubmissionDto
    {
        public string LoanProduct { get; set; }
        public string LoanRate { get; set; }
        public string PropertyStreetName { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZip { get; set; }
        public string DocFileId { get; set; }
        public string BorrowerCreditScore { get; set; }
        public string CuScore { get; set; }
        public string LcaScore { get; set; }
        public string Dti { get; set; }
        public string Ltv { get; set; }
        public string CraLoan { get; set; }
        public string InterestRate { get; set; }
        public string LoanAmount { get; set; }
    }
}
