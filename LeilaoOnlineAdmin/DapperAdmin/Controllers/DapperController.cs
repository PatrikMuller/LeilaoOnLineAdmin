using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DapperAdmin.Database;
using DapperAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace DapperAdmin.Controllers
{
    public class DapperController : Controller
    {

        string Connection = @"Server=localhost;Port=5432;Database=leilao_online;User Id=user_leilao_online;Password=detranR0;";

        public IActionResult Index()
        {
            return View();
        }

        public int Create(Login obj)
        {
            using (var connection = new NpgsqlConnection(Connection))
            {
                //string mysql = "insert into login (email, password) values (@email, @password); select currval(pg_get_serial_sequence('login','id'));";
                string mysql = "insert into login (email, password) values (@email, @password) returning id;";
                //var Params = new DynamicParameters();
                //Params.Add("?email", obj.Email);
                //Params.Add("?password", obj.Password);
                //SELECT LAST_INSERT_ID()
                //select last_insert_rowid();
                //SELECT CURRVAL(‘NOMEDATABELA_ID_TABELA_SEQ’)
                //Pega o próximo número antes de vc gravar alguma coisa ai vc pode fazer outras coisa com o ID.
                //connection.Query<Login>(mysql, )
                //connection.Query<Login>(mysql, obj);
                //var id = connection.ExecuteScalar<int>(mysql, obj);
                //obj.id = id;
                obj.id = connection.ExecuteScalar<int>(mysql, obj);
                //connection.Execute(mysql, obj);
                //connection.Execute(mysql);
            }
            return obj.id;
        }

        public JsonResult Update(Login obj)
        {

            obj.id = 1;

            using (var connection = new NpgsqlConnection(Connection))
            {
                string mysql = "update login set email = '"+obj.Email+"', password = '" + obj.Password + "'";
                connection.Execute(mysql);
            }
            return Json("");
        }

        public JsonResult Read(Login obj)
        {
            List<Login> retorno = new List<Login>();

            //using (var connection = new NpgsqlConnection(Connection))
            using (var connection = new LeilaoOnlineConnection().Connection())
            {
                string mysql = "select * from login";
                var Params = new DynamicParameters();
                //Params.Add("@flag", "Read");
                retorno = connection.Query<Login>(mysql, Params, commandType: System.Data.CommandType.Text).ToList();
            }
            return Json(retorno);
        }

    }
}