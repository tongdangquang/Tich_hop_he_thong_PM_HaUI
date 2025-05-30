using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    public class DefaultController : ApiController
    {
        List<Employee> list;
        public DefaultController()
        {
            list = new List<Employee>();
            list.Add(new Employee(1, "Nguyễn A", "Ha Noi", 1500));
            list.Add(new Employee(2, "Nguyễn B", "Quang Ninh", 2000));
            list.Add(new Employee(3, "Nguyễn C", "Thai Binh", 1600));
            list.Add(new Employee(4, "Nguyễn D", "Ha Noi", 1300));
            list.Add(new Employee(5, "Nguyễn E", "Hai Duong", 1800));
            list.Add(new Employee(6, "Nguyễn F", "Hai Phong", 1900));
            list.Add(new Employee(7, "Nguyễn G", "Thai Binh", 1500));
        }

		// 1. [HttpGet]: dùng để trả về dữ liệu
        // trả về danh sách nhân viên dạng xml
        [HttpGet]
		[Route("api/default")]
		public List<Employee> GetAllEmployees()
        {
            return list;
        }

        // trả về danh sách nhân viên có địa chỉ nhập trên thanh tìm kiếm
		[HttpGet]
        [Route("api/get_by_address")]
		public List<Employee> Get_by_address(string address)
		{
            List<Employee> list_by_address = list.Where(e => e.address == address).ToList();

			return list_by_address;
		}

		// trả về thông tin nhân viên có empid được nhập từ bàn phím
		[HttpGet]
		[Route("api/get_by_empid")]
		public Employee Get_by_empid(int id)
		{
			Employee emp = list.SingleOrDefault(e => e.empid == id);
			return emp;
		}

		// tính tổng 2 số 
		[HttpGet]
		[Route("api/get_sum")]
		public int Get_Sum(int a, int b)
		{
			return a + b;
		}

		// 2. [HttpPost]: dùng để thêm mới dữ liệu
		// thêm một đối tượng Employee vào danh sách
		[HttpPost]
		[Route("api/post_add_epmloyee")]
		public int Add_Employee([FromBody] Employee emp)
		{
			try
			{
				list.Add(emp);
				return list.Count;
			}
			catch
			{ 
				return -1; 
			}
		}

		// 3. [HttpPut]: dùng để cập nhật dữ liệu
		// cập nhật thông tin nhân viên
		[HttpPut]
		[Route("api/put_update_employee")]
		public string Update_Employee()
		{
			return "Test put method!";
		}

		// 3. [HttpDelete]: dùng để xóa dữ liệu
		// xóa nhân viên khỏi danh sách
		[HttpDelete]
		[Route("api/delete_remove_employee")]
		public int Delete_Employee(int id)
		{
			try
			{
				list.Remove(list.SingleOrDefault(e => e.empid == id));
				return list.Count;
			}
			catch
			{
				return -1;
			}
		}
	}
}
