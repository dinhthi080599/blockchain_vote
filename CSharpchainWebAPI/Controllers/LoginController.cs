using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.EntityFrameworkCore;
using CSharpchainWebAPI.Models;

namespace CSharpchainWebAPI.Controllers
{
    public class LoginController : ApiController
    {
        public IHttpActionResult GetAllAccount()
        {
            IList<Account> students = null;

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }
        public IHttpActionResult GetAllStudents(String sTenDangNhap = "", String sMatKhau = "")
        {
            IList<Account> account = null;

            using (var ctx = new qlnhEntities1())
            {
                account = ctx.tbl_taikhoan
                            .Where(s => sTenDangNhap == "" ? s.iTrangThai == 1 || s.iTrangThai == 0 : s.sTenDangNhap == sTenDangNhap)
                            .Select(s => new Account()
                            {
                                Id = s.id,
                                userName = s.sTenDangNhap,
                                passWord = s.sMatKhau
                            }).ToList<Account>();
            }
           
            if (account.Count == 0)
            {
                return NotFound();
            }
            else if (account[0].passWord != sMatKhau && account.Count == 1)
            {
                return NotFound();
            }

            return Ok(account);
        }
    }
}
