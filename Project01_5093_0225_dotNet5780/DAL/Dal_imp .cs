using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    internal class Dal_imp :IDAL
    {
        //public static List<HostingUnit> My_HostingUnitList = new List<HostingUnit>();
        //public static List<GuestRequest> My_guestRequestsList;//= new List<GuestRequest>();
        //public static List<Order> My_ordersList = new List<Order>(); 
        public Dal_imp()
        {

        }
    
        public void addGuestRequest(GuestRequest My_GuestRequest)
        {


           
        }
        public void Requirement_update(GuestRequest My_GuestRequest)
        {
            throw new NotImplementedException();
        }

        public void addHostingUnit(HostingUnit My_HostingUnit)
        {
            throw new NotImplementedException();
        }

        public void deleteHostingUnit(long hosting_unit)
        {
            throw new NotImplementedException();
        }

        public void UpdateHostingUnit(HostingUnit My_HostingUnit)
        {
            throw new NotImplementedException();
        }

        public void addOrder(Order My_Order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order My_Order)
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> My_HostingUnitList()
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> My_GuestRequestsList()
        {
            throw new NotImplementedException();
        }

        public List<Order> My_OrdersList()
        {
            throw new NotImplementedException();
        }

        public List<BankBranch> My_BankBranchList()
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> My_guestRequestsList()
        {
            throw new NotImplementedException();
        }
    }

    internal class My_GuestRequestsList
    {
        internal static void Add(GuestRequest my_GuestRequest)
        {
            throw new NotImplementedException();
        }
    }
}
