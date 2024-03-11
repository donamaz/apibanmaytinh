using BanMayTinh_V2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BanMayTinh_V2.Code;

namespace BanMayTinh_V2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SanPhamController : ControllerBase
    {
        private BanMayTinhContext db = new BanMayTinhContext();
        [Route("get-by-id/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            try
            {
                var sp = db.SanPhams.Where(x => x.MaSanPham == id).Select(
                    x => new { x.MaSanPham, x.TenSanPham, x.NgayTao, x.ChiTietAnhSanPhams }).SingleOrDefault();
                return Ok(sp);

            }
            catch
            {
                return BadRequest();
            }
        }
        [Route("create-sanpham")]
        [HttpPost]
        public IActionResult CreateSanPham(SanPhamModels model)
        {
            try
            {
                model.sanpham.NgayTao = DateTime.Now;
                db.SanPhams.Add(model.sanpham);
                db.SaveChanges();
                if (model.listchitiet != null && model.listchitiet.Count > 0)
                {
                    foreach (var x in model.listchitiet)
                        x.MaSanPham = model.sanpham.MaSanPham;
                    model.sanpham.ChiTietAnhSanPhams = model.listchitiet;
                    db.SaveChanges();
                }
                return Ok("OK");
            }
            catch
            {
                return BadRequest();
            }
        }
        [Route("update-sanpham")]
        [HttpPost]
        public IActionResult UpdateSanPham(SanPhamEditModels model)
        {
            try
            {
                var sp = db.SanPhams.SingleOrDefault(x => x.MaSanPham == model.sanpham.MaSanPham);
                sp.TenSanPham = string.IsNullOrEmpty(model.sanpham.TenSanPham) ? sp.TenSanPham : model.sanpham.TenSanPham;
                sp.MoTaSanPham = model.sanpham.MoTaSanPham;
                sp.AnhDaiDien = model.sanpham.AnhDaiDien;
                db.SaveChanges();
                if (model.listchitiet != null && model.listchitiet.Count > 0)
                {
                    foreach (var x in model.listchitiet)
                    {
                        if (x.TrangThai == 1)
                        {
                            var anh = new ChiTietAnhSanPham();
                            anh.Anh = x.Anh;
                            anh.MaSanPham = sp.MaSanPham;
                            db.ChiTietAnhSanPhams.Add(anh);
                            db.SaveChanges();
                        }
                        else if (x.TrangThai == 0)
                        {
                            var obj = db.ChiTietAnhSanPhams.SingleOrDefault(s => s.MaAnhChitiet == x.MaAnhChitiet);
                            db.ChiTietAnhSanPhams.Remove(obj);
                            db.SaveChanges();
                        }
                    }
                  
                }
                return Ok("OK");
            }
            catch
            {
                return BadRequest();
            }
        }

        [Route("delete-sanpham")]
        [HttpDelete]
        public IActionResult DeleteSanPham(int MaSanPham)
        {
            try
            {
                var sp = db.SanPhams.SingleOrDefault(x => x.MaSanPham == MaSanPham);
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return Ok("OK");
            }
            catch
            {
                return BadRequest();
            }
        }

        [Route("search")]
        [HttpPost]
        public ResponseModel Search([FromBody] Dictionary<string, object> formData)
        {
            var response = new ResponseModel();
            try
            {
                var page = int.Parse(formData["page"].ToString());
                var pageSize = int.Parse(formData["pageSize"].ToString());
                int? MaDanhMuc = null;
                if (formData.Keys.Contains("MaDanhMuc") && !string.IsNullOrEmpty(Convert.ToString(formData["MaDanhMuc"]))) { MaDanhMuc = Convert.ToInt32(formData["MaDanhMuc"].ToString()); }
                string TenSanPham = "";
                if (formData.Keys.Contains("TenSanPham") && !string.IsNullOrEmpty(Convert.ToString(formData["TenSanPham"]))) { TenSanPham = Convert.ToString(formData["TenSanPham"]); }
                var data = db.SanPhams.Where(x => (MaDanhMuc == null || x.MaDanhMuc == MaDanhMuc) && (TenSanPham == "" || x.TenSanPham.Contains(TenSanPham))).
                    Select(x => new { x.MaSanPham, x.TenSanPham, x.MoTaSanPham, x.ChiTietAnhSanPhams }).ToList();
                response.TotalItems = data.Count;
                response.Page = page;
                response.PageSize = pageSize;
                response.Data = data.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return response;
        }
    
    }
}