using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi_14_03.Controller
{
    public class Customers3Controller : ApiController
    {
        //httpGet: dùng để lấy thông tin khách hàng
        //1. Dịch vụ lấy thông tin của toàn bộ khách hàng
        [HttpGet]
        public List<Hang> GetCustomerLists()
        {

            //KhachDataContext 


            DBCustomers31DataContext dbCustomer = new
            DBCustomers31DataContext();
            return dbCustomer.Hangs.ToList();
        }
        //2. Dịch vụ lấy thông tin một khách hàng với mã nào do

        [HttpGet]
        public Hang GetCustomer(string id)
        {
            DBCustomers31DataContext dbCustomer = new
           DBCustomers31DataContext();
            return dbCustomer.Hangs.FirstOrDefault(x =>
           x.MaKhach == id);
        }

        [HttpGet]
        public List<Hang> GetCustomer1(string taikhoan)
        {
            DBCustomers31DataContext dbCustomer = new
           DBCustomers31DataContext();
            List<Khach> tlist = new List<Khach>();

            return dbCustomer.Hangs.Where(x =>
           x.TaiKhoan.Contains(taikhoan)).ToList();
        }
        //3. httpPost, dịch vụ thêm mới một khách hàng
        [HttpPost]
        public bool InsertNewCustomer(string id, string name,
       string adress, string phoneNumber, string id_sach, int sl, string taikhoan , string trangthai ,int tongtien)
        {
            try
            {
                DBCustomers31DataContext dbCustomer = new
               DBCustomers31DataContext();
                Hang customer = new Hang();
                customer.MaKhach = id;
                customer.TenKhach = name;
                customer.DiaChi = adress;
                customer.DienThoai = phoneNumber;
                customer.MaSach = id_sach;
                customer.SLMua = sl;
                customer.TaiKhoan = taikhoan;
                customer.TrangThai = trangthai;
                customer.TongGia = tongtien ;


                dbCustomer.Hangs.InsertOnSubmit(customer);
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
       string adress, string phoneNumber, string id_sach, int sl, string taikhoan , string trangthai , int tongtien)

        {
            try
            {
                DBCustomers31DataContext dbCustomer = new
               DBCustomers31DataContext();
                //Lấy mã khách đã có
                Hang customer =
               dbCustomer.Hangs.FirstOrDefault(x => x.MaKhach == id);
                if (customer == null) return false;
                customer.MaKhach = id;
                customer.TenKhach = name;
                customer.DiaChi = adress;
                customer.DienThoai = phoneNumber;
                customer.MaSach = id_sach;
                customer.SLMua = sl;
                customer.TaiKhoan = taikhoan;
                customer.TrangThai= trangthai;
                customer.TongGia = tongtien;



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
                DBCustomers31DataContext dbCustomer = new
               DBCustomers31DataContext();
                //Lấy mã khách đã có
                Hang customer =
               dbCustomer.Hangs.FirstOrDefault(x => x.MaKhach == id);
                if (customer == null) return false;

                dbCustomer.Hangs.DeleteOnSubmit(customer);
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
