using AVSupplier.Application.Models;
using AVSupplier.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVSupplier.Application.Interfaces
{
    public interface IAdminMasterRepository
    {
        #region Blood Group

        Task<int> SaveBloodGroup(BloodGroup_Request parameters);
        Task<IEnumerable<BloodGroup_Response>> GetBloodGroupList(BloodGroup_Search parameters);
        Task<BloodGroup_Response?> GetBloodGroupById(long Id);

        #endregion

        #region Company Type

        Task<int> SaveCompanyType(CompanyType_Request parameters);
        Task<IEnumerable<CompanyType_Response>> GetCompanyTypeList(CompanyType_Search parameters);
        Task<CompanyType_Response?> GetCompanyTypeById(long Id);

        #endregion

        #region Employee Level

        Task<int> SaveEmployeeLevel(EmployeeLevel_Request parameters);
        Task<IEnumerable<EmployeeLevel_Response>> GetEmployeeLevelList(EmployeeLevel_Search parameters);
        Task<EmployeeLevel_Response?> GetEmployeeLevelById(long Id);

        #endregion

        #region Machine

        Task<IEnumerable<Machine_Response>> GetMachineList(Machine_Search parameters);

        #endregion

        #region Part

        Task<IEnumerable<Part_Response>> GetPartList(Part_Search parameters);

        #endregion

        #region KTTM Customer

        Task<int> SaveKTTMCustomer(KTTMCustomer_Request parameters);
        Task<IEnumerable<KTTMCustomer_Response>> GetKTTMCustomerList(KTTMCustomer_Search parameters);
        Task<KTTMCustomer_Response?> GetKTTMCustomerById(long Id);

        #endregion
    }
}
