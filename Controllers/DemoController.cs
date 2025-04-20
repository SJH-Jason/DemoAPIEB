using DemoAPIEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace DemoAPIEB.Controllers
{
    public class DemoController
    {
    }

    [ApiController]
    [Route("api/[controller]")]
    public class BusinessDataController : ControllerBase
    {
        private readonly DemoDataListContext _context;

        public BusinessDataController(DemoDataListContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.DemoData.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCompanyCode(string code)
        {
            var result = await _context.DemoData
                .Where(x => x.公司代號.ToString() == code)
                .ToListAsync();

            return Ok(result);
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert([FromBody] InsertDTO dto)
        {
            try
            {
                var sql = @"
                EXEC usp_InsertDemoData 
                    @出表日期, @資料年月, @公司代號, @公司名稱, @產業別,
                    @營業收入_當月營收, @營業收入_上月營收, @營業收入_去年當月營收,
                    @營業收入_上月比較增減, @營業收入_去年同月增減,
                    @累計營業收入_當月累計營收, @累計營業收入_去年累計營收,
                    @累計營業收入_前期比較增減, @備註";

                var parameters = new[]
                {
                new SqlParameter("@出表日期", dto.出表日期),
                new SqlParameter("@資料年月", dto.資料年月),
                new SqlParameter("@公司代號", dto.公司代號),
                new SqlParameter("@公司名稱", dto.公司名稱),
                new SqlParameter("@產業別", dto.產業別),
                new SqlParameter("@營業收入_當月營收", dto.營業收入_當月營收),
                new SqlParameter("@營業收入_上月營收", dto.營業收入_上月營收),
                new SqlParameter("@營業收入_去年當月營收", dto.營業收入_去年當月營收),
                new SqlParameter("@營業收入_上月比較增減", dto.營業收入_上月比較增減),
                new SqlParameter("@營業收入_去年同月增減", dto.營業收入_去年同月增減),
                new SqlParameter("@累計營業收入_當月累計營收", dto.累計營業收入_當月累計營收),
                new SqlParameter("@累計營業收入_去年累計營收", dto.累計營業收入_去年累計營收),
                new SqlParameter("@累計營業收入_前期比較增減", dto.累計營業收入_前期比較增減),
                new SqlParameter("@備註", dto.備註)
            };

                await _context.Database.ExecuteSqlRawAsync(sql, parameters);

                return Ok(new { success = true, message = "新增成功" });
            }
            catch (SqlException ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }
}
