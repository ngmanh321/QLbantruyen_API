using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi_14_03.Controller
{
    public class Customers1Controller : ApiController
    {
        //httpGet: dùng để lấy thông tin khách hàng
        //1. Dịch vụ lấy thông tin của toàn bộ khách hàng
        [HttpGet]
        public List<Sach> GetCustomerLists()
        {
            //KhachDataContext 

            DBCustomers1DataContext dbCustomer = new
            DBCustomers1DataContext();
            return dbCustomer.Saches.ToList();
        }
        //2. Dịch vụ lấy thông tin một khách hàng với mã nào do

        [HttpGet]
        public Sach GetCustomer(string id)
        {
            DBCustomers1DataContext dbCustomer = new
           DBCustomers1DataContext();
            return dbCustomer.Saches.FirstOrDefault(x =>
           x.MaSach == id);
        }
        //3. httpPost, dịch vụ thêm mới một khách hàng
        [HttpPost]
        public bool InsertNewCustomer(string id, string name,
       string giasach, int sls)
        {
            try
            {
                DBCustomers1DataContext dbCustomer = new
               DBCustomers1DataContext();
                Sach customer = new Sach();
                customer.MaSach = id;
                customer.TenSach = name;
                customer.GiaSach = giasach;
                customer.SLSach = sls;

                dbCustomer.Saches.InsertOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //4. httpPut để chỉnh sửa thông tin một khách hàng
        [HttpPut]
        public bool UpdateCustomer(string id, string name,
       string giasach, int sls)

        {
            try
            {
                DBCustomers1DataContext dbCustomer = new
               DBCustomers1DataContext();
                //Lấy mã khách đã có
                Sach customer =
               dbCustomer.Saches.FirstOrDefault(x => x.MaSach == id);
                if (customer == null) return false;
                customer.MaSach = id;
                customer.TenSach = name;
                customer.GiaSach = giasach;
                customer.SLSach = sls;
                dbCustomer.SubmitChanges();//Xác nhận chỉnh 

                return true;
            }
            catch
            {
                return false;
            }
        }
        //5.httpDelete để xóa một Khách hàng
        [HttpDelete]
        public bool DeleteCustomer(string id)
        {
            try
            {
                DBCustomers1DataContext dbCustomer = new
               DBCustomers1DataContext();
                //Lấy mã khách đã có
                Sach customer =
               dbCustomer.Saches.FirstOrDefault(x => x.MaSach == id);
                if (customer == null) return false;

                dbCustomer.Saches.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
