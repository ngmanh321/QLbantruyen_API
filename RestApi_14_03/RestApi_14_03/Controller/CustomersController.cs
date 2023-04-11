using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi_14_03.Controller
{
    public class CustomersController : ApiController
    {
        //httpGet: dùng để lấy thông tin khách hàng
        //1. Dịch vụ lấy thông tin của toàn bộ khách hàng
        [HttpGet]
        public List<Khach> GetCustomerLists()
        {
            
            //KhachDataContext 


           KhachDataContext dbCustomer = new
           KhachDataContext();
            return dbCustomer.Khaches.ToList();
        }
        //2. Dịch vụ lấy thông tin một khách hàng với mã nào do
        
         [HttpGet]
        public Khach GetCustomer(string id)
        {
            KhachDataContext dbCustomer = new
           KhachDataContext();
            return dbCustomer.Khaches.FirstOrDefault(x =>
           x.MaKhach == id);
        }

        [HttpGet]
        public List<Khach> GetCustomer1(string taikhoan)
        {
            KhachDataContext dbCustomer = new
           KhachDataContext();
            List<Khach> tlist = new List<Khach>();
            
            return dbCustomer.Khaches.Where(x =>
           x.TaiKhoan.Contains(taikhoan)).ToList();
        }
        //3. httpPost, dịch vụ thêm mới một khách hàng
        [HttpPost]
        public bool InsertNewCustomer(string id, string name,
       string adress, string phoneNumber ,string id_sach, int sl ,string taikhoan )
        {
            try
            {
                KhachDataContext dbCustomer = new
               KhachDataContext();
                Khach customer = new Khach();
                customer.MaKhach = id;
                customer.TenKhach = name;
                customer.DiaChi = adress;
                customer.DienThoai = phoneNumber;
                customer.MaSach = id_sach;
                customer.SLMua = sl;
                customer.TaiKhoan = taikhoan;

                dbCustomer.Khaches.InsertOnSubmit(customer);
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
       string adress, string phoneNumber , string id_sach, int sl , string taikhoan )

 {
             try
             {
             KhachDataContext dbCustomer = new
            KhachDataContext();
                    //Lấy mã khách đã có
                    Khach customer =
                   dbCustomer.Khaches.FirstOrDefault(x => x.MaKhach == id);
             if (customer == null) return false;
             customer.MaKhach = id;
             customer.TenKhach = name;
             customer.DiaChi = adress;
             customer.DienThoai = phoneNumber;
             customer.MaSach = id_sach;
             customer.SLMua = sl;
             customer.TaiKhoan = taikhoan;


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
                KhachDataContext dbCustomer = new
               KhachDataContext();
                //Lấy mã khách đã có
                Khach customer =
               dbCustomer.Khaches.FirstOrDefault(x => x.MaKhach == id);
                if (customer == null) return false;

                dbCustomer.Khaches.DeleteOnSubmit(customer);
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
