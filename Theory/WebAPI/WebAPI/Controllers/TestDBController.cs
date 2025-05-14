using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.ModelBinding;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class TestDBController : ApiController
    {
        WineStore data = new WineStore();

        // xem danh sách catalogy
        [HttpGet]
        [Route("api/ds_cata")]
        public List<Catalogy> ds()
        {
            return data.Catalogy.ToList();
        }

        // xem danh sách sản phẩm thuộc thể loại có mã thể loại nhập từ thanh url
        [HttpGet]
        [Route("api/ds_cata")]
        public List<Product> ds_cata(string mact)
        {
            return data.Product.Where(p => p.CatalogyID == mact).ToList();
        }

        // thêm catalogy
        [HttpPost]
        [Route("api/ds_them")]
        public string Them_catalogy([FromBody] Catalogy ct)
        {
            try
            {
                data.Catalogy.Add(ct);
                data.SaveChanges();
                return "Thêm thành công";
            }
            catch(Exception ex)
            {
                return "Có lỗi khi thêm: " + ex.InnerException;
            }
        }

		// sửa thông tin catalogy
		[HttpPost]
		[Route("api/ds_sua")]
		public string Sua_catalogy([FromBody] Catalogy ct_update)
        {
            try
            {
                Catalogy ct = data.Catalogy.SingleOrDefault(c => c.CatalogyID == ct_update.CatalogyID);
                ct.CatalogyName = ct_update.CatalogyName;
                ct.Description = ct_update.Description;

                data.SaveChanges();
                return "Sửa thành công!";
            }
            catch (Exception ex)
            {
                return "Có lỗi khi sửa: " + ex.InnerException;
            }
        }

		// xóa catalogy
		[HttpDelete]
		[Route("api/ds_xoa/{mact}")]
        public string Xoa_catalogy(string mact)
        {
            Catalogy c = data.Catalogy.Find(mact);
            if (c == null)
                return "Không tìm thấy thể loại cần xóa!";
            try
            {
                data.Catalogy.Remove(c);
                data.SaveChanges();
                return "Xóa thành công!";
            }
            catch (Exception ex)
            {
                return "Có lỗi trong quá trình xóa: " + ex.InnerException;
            }
        }
    }
}
