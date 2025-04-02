using AVSupplier.Domain.Entities;
using AVSupplier.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AVSupplier.Application.Models
{
    #region Blood Group
    public class BloodGroup_Search : BaseSearchEntity
    {
    }

    public class BloodGroup_Request : BaseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    public class BloodGroup_Response : BaseResponseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Company Type

    public class CompanyType_Search : BaseSearchEntity
    {
    }

    public class CompanyType_Request : BaseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CompanyType_Response : BaseResponseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Employee Level
    public class EmployeeLevel_Search : BaseSearchEntity
    {
    }

    public class EmployeeLevel_Request : BaseEntity
    {
        public string? EmployeeLevel { get; set; }
        public bool? IsActive { get; set; }
    }

    public class EmployeeLevel_Response : BaseResponseEntity
    {
        public string? EmployeeLevel { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Machine
    public class Machine_Search : BaseSearchEntity
    {
    }

    public class Machine_Request : BaseEntity
    {
        public string? MachineNumber { get; set; }
        public string? SpecNo { get; set; }
        public string? SpecDetails { get; set; }
        public string? ManufactureYear { get; set; }
        public DateTime? CommissionDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Machine_Response : BaseResponseEntity
    {
        public string? MachineNumber { get; set; }
        public string? SpecNo { get; set; }
        public string? SpecDetails { get; set; }
        public string? ManufactureYear { get; set; }
        public DateTime? CommissionDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Part
    public class Part_Search : BaseSearchEntity
    {
    }

    public class Part_Request : BaseEntity
    {
        public string? PartNumber { get; set; }
        public string? PartName { get; set; }
        public string? Unit { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? OrderQty { get; set; }
        public decimal? StockQty { get; set; }

        [DefaultValue("")]
        public string? PartOriginalFileName { get; set; }

        [JsonIgnore]
        public string? PartFileName { get; set; }

        [DefaultValue("")]
        public string? Part_Base64 { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Part_Response : BaseResponseEntity
    {
        public string? PartNumber { get; set; }
        public string? PartName { get; set; }
        public string? Unit { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? OrderQty { get; set; }
        public decimal? StockQty { get; set; }
        public string? PartOriginalFileName { get; set; }
        public string? PartFileName { get; set; }
        public string? PartUrl { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region KTTM Customer
    public class KTTMCustomer_Search : BaseSearchEntity
    {
    }

    public class KTTMCustomer_Request : BaseEntity
    {
        public string? CustomerName { get; set; }
        public string? Designation { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailId { get; set; }
        public bool? IsActive { get; set; }
    }

    public class KTTMCustomer_Response : BaseResponseEntity
    {
        public string? CustomerName { get; set; }
        public string? Designation { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailId { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion
}
