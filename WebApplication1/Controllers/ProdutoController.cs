using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var lstProduto = new List<Produto>();
            using (var conexao = new Conexao())
            {
                string strProdutos = "SELECT * FROM produto where isExcluido = false order by Descricao;";
                using (var comando = new MySqlCommand(strProdutos, conexao.conn))
                {
                    MySqlDataReader dr = comando.ExecuteReader();
                    if (dr.HasRows)
                        while (dr.Read())
                        {
                            var produto = new Produto
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Descricao = Convert.ToString(dr["Descricao"])
                            };

                            lstProduto.Add(produto);
                        }
                    ViewBag.ListaProduto = lstProduto;
                }
            }
            return View();
        }
    }
}