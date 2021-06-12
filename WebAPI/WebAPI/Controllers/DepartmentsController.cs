using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models; //import Departments Model from Model
using System.Data; //for data 
using System.Data.SqlClient;
using System.Configuration;

namespace WebAPI.Controllers
{
    public class DepartmentsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();
            string query = @"select DepartmentID, DepartmentName from Departments";
            using (var con = new SqlConnection(ConfigurationManager.
                   ConnectionStrings["EmployeeAppDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
        public String Post(Departments departments)
        {
            try
            {
                DataTable table = new DataTable();
                string query = @"insert into Departments values ( '" + departments.DepartmentName +"' )";
                using (var con = new SqlConnection(ConfigurationManager.
                       ConnectionStrings["EmployeeAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Saved Successfully!";
            }
            catch
            {
                return "Failed to Save!";
            }
        }
    }
}
