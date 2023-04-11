using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi_14_03.Controller
{
    public class Customers2Controller : ApiController
    {
        //httpGet: dùng để lấy thông tin khách hàng
        //1. Dịch vụ lấy thông tin của toàn bộ khách hàng
        [HttpGet]
        public List<TaiKhoan> GetCustomerLists()
        {
            //KhachDataContext 

            DBCustomers2DataContext dbCustomer = new
            DBCustomers2DataContext();
            return dbCustomer.TaiKhoans.ToList();
        }
        //2. Dịch vụ lấy thông tin một khách hàng với mã nào do

        [HttpGet]
        public TaiKhoan GetCustomer(string id)
        {
            DBCustomers2DataContext dbCustomer = new
           DBCustomers2DataContext();
            return dbCustomer.TaiKhoans.FirstOrDefault(x =>
           x.Ten == id);
        }
        //3. httpPost, dịch vụ thêm mới một khách hàng
        [HttpPost]
        public bool InsertNewCustomer(string id, string mk, string loai)
        {
            try
            {
                DBCustomers2DataContext dbCustomer = new
               DBCustomers2DataContext();
                TaiKhoan customer = new TaiKhoan();
                customer.Ten = id;
                customer.MatKhau = mk;
                customer.LoaiTK = loai;


                dbCustomer.TaiKhoans.InsertOnSubmit(customer);
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
        public bool UpdateCustomer(string id, string mk ,string loai)

        {
            try
            {
                DBCustomers2DataContext dbCustomer = new
               DBCustomers2DataContext();
                //Lấy mã khách đã có
                TaiKhoan customer =
               dbCustomer.TaiKhoans.FirstOrDefault(x => x.Ten == id);
                if (customer == null) return false;
                customer.Ten = id;
                customer.MatKhau = mk;
                customer.LoaiTK = loai;

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
                DBCustomers2DataContext dbCustomer = new
               DBCustomers2DataContext();
                //Lấy mã khách đã có
                TaiKhoan customer =
               dbCustomer.TaiKhoans.FirstOrDefault(x => x.Ten == id);
                if (customer == null) return false;

                dbCustomer.TaiKhoans.DeleteOnSubmit(customer);
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
