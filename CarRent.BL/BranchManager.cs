using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRent.Entities;
using CarRent.DAL;

namespace CarRent.BL
{
    public  class BranchManager
    {
        public IEnumerable<Branch> GetBranchs()
        {
            using (var context = new RentContext())
            {
                return context.Branches.ToArray();
            }
        }
        public Branch GetBranchById(int BranchId)
        {
            using (var context = new RentContext())
            {
                return context.Branches.Find(BranchId);
            }
        }

        public void AddBranch(Branch Branch)
        {
            using (var context = new RentContext())
            {
                context.Branches.Attach(Branch);
                context.Entry(Branch).State = Branch.BranchId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoveBranch(int BranchId)
        {
            using (var context = new RentContext())
            {
                Branch BranchToDelete = context.Branches.Find(BranchId);
                if (BranchToDelete != null)
                {
                    context.Entry(BranchToDelete).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                else
                {
                    // TODO: if CarToDelete is null, report it or return something

                }
            }
        }

    }
}
