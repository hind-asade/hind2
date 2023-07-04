using System.Reflection.Metadata.Ecma335;
using BlazorApp2.Data;
using BlazorApp2.Modles;
using BlazorApp2.RepositoriesPattern.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.RepositoriesPattern.Repositories
{
    public class StaffRepo : IStaff
    {
        private ApplicationDbContext Db;

        public StaffRepo(ApplicationDbContext db)
        {
            Db = db;
        }

        


        async Task<string> IStaff.AddStaffMember(StaffModle NewEmp)
        {
            Db.StaffTable.Add(NewEmp);
            Db.SaveChanges();
            return "The Emp Has Been Added To The DataBase";

        }

        public async Task<List<StaffModle>> GetAllStaff()
        {
            var ListOfAllStaff = await Db.StaffTable.ToListAsync();
            return ListOfAllStaff;
        
        }

        string IStaff.AddStaffMember(StaffModle NewEmp)
        {
            throw new NotImplementedException();
        }
    }
    
}
