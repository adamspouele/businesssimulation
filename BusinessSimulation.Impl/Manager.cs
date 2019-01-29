using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public class Manager : IManager
    {
        private List<IProduct> m_products;
        private List<IOrder> m_orders;
        private List<ICompany> m_companies;
        private List<ICustomer> m_customers;
        private List<IVat> m_vats;

        public Manager()
        {
            m_products = new List<IProduct>();
            m_orders = new List<IOrder>();
            m_companies = new List<ICompany>();
            m_customers = new List<ICustomer>();
        }

        public void AddCompany(ICompany company)
        {
            m_companies.Add(company);
        }

        public void AddOrder(IOrder order)
        {
            m_orders.Add(order);
        }

        public void AddProduct(IProduct product)
        {
            m_products.Add(product);
        }

        public void AddCustomer(ICustomer customer)
        {
            m_customers.Add(customer);
        }

        public void AddVat(IVat vat)
        {
            m_vats.Add(vat);
        }

        public List<ICompany> GetCompanies()
        {
            return m_companies;
        }

        public List<IOrder> GetOrders()
        {
            return m_orders;
        }

        public List<IProduct> GetProducts()
        {
            return m_products;
        }

        public List<ICustomer> GetCustomers()
        {
            return m_customers;
        }

        public void RemoveCompany(ICompany company)
        {
            m_companies.Remove(company);
        }

        public void RemoveOrder(IOrder order)
        {
            m_orders.Remove(order);
        }

        public void RemoveProduct(IProduct product)
        {
            m_products.Remove(product);
        }

        public void RemoveCustomer(ICustomer customer)
        {
            m_customers.Remove(customer);
        }

        public IProduct AssignRandomCompanyToProduct(IProduct product)
        {
            if (!m_products.Contains(product)) return null;

            var random = new Random();

            product.Company = m_companies[random.Next(0, m_companies.Count - 1)];

            return product;
        }

        public List<IVat> GetVats()
        {
            return m_vats;
        }

        public void RemoveVat(IVat vat)
        {
            m_vats.Remove(vat);
        }
    }
}
