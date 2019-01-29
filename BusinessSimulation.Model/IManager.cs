using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface IManager
    {
        void AddProduct(IProduct product);
        void AddOrder(IOrder order);
        void AddCompany(ICompany company);
        void AddCustomer(ICustomer customer);

        List<IProduct> GetProducts();
        List<IOrder> GetOrders();
        List<ICompany> GetCompanies();
        List<ICustomer> GetCustomers();

        void RemoveProduct(IProduct product);
        void RemoveOrder(IOrder order);
        void RemoveCompany(ICompany company);
        void RemoveCustomer(ICustomer compcustomerany);
        IProduct AssignRandomCompanyToProduct(IProduct product);
    }
}
