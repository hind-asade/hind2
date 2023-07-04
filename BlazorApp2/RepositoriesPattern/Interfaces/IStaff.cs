
using BlazorApp2.Modles;

namespace BlazorApp2.RepositoriesPattern.Interfaces
{
    public interface IStaff
    {
        public Task<string> AddStaffMember(StaffModle NewEmp);
        string AddStaffMember (StaffModle NewEmp);
        public Task<List<StaffModle>> GetAllStaff();
    }
}
