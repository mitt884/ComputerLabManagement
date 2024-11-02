using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ComputerLabManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CLabManagementController : ControllerBase
    {
        private IConfiguration _configuration;

        public  ComputerLabManagement(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetNotes")]
        public JsonResult GetNotes()
        {
            string query = "select + from dbo.Notes";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("CLabManagement");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDatasource))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand )
            }

        }
    }
}
