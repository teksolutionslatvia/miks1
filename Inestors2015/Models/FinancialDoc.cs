//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Investors2015.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FinancialDoc
    {
        public FinancialDoc()
        {
            this.FinancialDoc1 = new HashSet<FinancialDoc>();
            this.FinancialDocLines = new HashSet<FinancialDocLine>();
            this.FinancialDocLines1 = new HashSet<FinancialDocLine>();
        }
    
        public int FinancialDocID { get; set; }
        public string FinancialDocNo { get; set; }
        public string FinancialDocNoSerial { get; set; }
        public int DocumentTypeID { get; set; }
        public int DocumentGroupID { get; set; }
        public Nullable<int> AccountingObjectID { get; set; }
        public System.DateTime FinancialDocDate { get; set; }
        public byte DocStatus { get; set; }
        public byte DocChangeStatus { get; set; }
        public int DocCurrencyID { get; set; }
        public decimal DocAmount { get; set; }
        public bool DocAmountLocked { get; set; }
        public Nullable<int> PartnerID { get; set; }
        public Nullable<int> PartnerVatCountryID { get; set; }
        public string PartnerVatNo { get; set; }
        public string PartnerContactPerson { get; set; }
        public Nullable<int> CompanyVatCountryID { get; set; }
        public string CompanyVatNo { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<int> CancelDocID { get; set; }
        public Nullable<System.DateTime> DisbursementTerm { get; set; }
        public bool Disbursement { get; set; }
        public Nullable<System.DateTime> DisbursementDate { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DocRegDate { get; set; }
        public string DocRegNo { get; set; }
        public string DocRegNoIndex { get; set; }
        public Nullable<System.Guid> SemoDocGUID { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string DocComputedNo { get; set; }
    
        public virtual DocumentGroup DocumentGroup { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<FinancialDoc> FinancialDoc1 { get; set; }
        public virtual FinancialDoc FinancialDoc2 { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual Partner Partner1 { get; set; }
        public virtual ICollection<FinancialDocLine> FinancialDocLines { get; set; }
        public virtual ICollection<FinancialDocLine> FinancialDocLines1 { get; set; }
    }
}
