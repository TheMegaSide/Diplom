using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using FInalProject.Models;
using FInalProject.Util.DB;
using FInalProject.Util.DbHandlers;

namespace FInalProject.Services
{
    public class BDService
    {
        public readonly string ConnectionString;

        public BDService(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("OracleDBConnection");
        }

        public List<Product> GetProductList()
        {
            string comText =
                "select * from Products";
            return DbExecutor.Execute<Product>(ConnectionString, comText, new DbProductHandler());
        }
        public Product GetProductById(int id)
        {
            string comText =
                "select *  from Products where Productid="+id;
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Product>(ConnectionString, comText, new DbProductHandler())[0];
        }
        public void ProductEdit(Product product)
        {
            string comText =
                "Update Products set Productname='" + product.ProductName + "',PRODUCTINDEX='" + product.ProductIndex +
                "',PRODUCTUNIT='" + product.ProductUnit + "',CATEGORYID=" + product.CategoryId + ",SELLERID=" +
                product.SellerId +
                ",STOCKID=" + product.StockId + ",PRODUCTPRICE=" + product.ProductPrice + ",PRODUCTDATE=" +
                "TRUNC(TO_DATE('" + product.ProductDate + "','MM-DD-YYYY HH:MI:SS')) "+
                ",AMOUNT=" + product.Amount +
                " where productid=" + product.ProductId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbProductHandler());
        }

        public void AddProduct(Product product)
        {
            string comText =
                "Insert into Products(PRODUCTNAME,PRODUCTINDEX,PRODUCTUNIT,CATEGORYID,SELLERID,STOCKID,PRODUCTPRICE,PRODUCTDATE,AMOUNT) values('" +
                product.ProductName + "','" + product.ProductIndex + "','" + product.ProductUnit + "',"
                + product.CategoryId + "," + product.SellerId + "," + product.StockId + "," + product.ProductPrice +
                ",TRUNC(TO_DATE('" + product.ProductDate + "','MM-DD-YYYY HH:MI:SS'))," + product.Amount + ") ";

            DbExecutor.Execute(ConnectionString, comText, new DbProductHandler());
        }


        public List<Client> GetClientList()
        {
            string comText =
                "select *  from Clients";
            return DbExecutor.Execute<Client>(ConnectionString, comText, new DbClientHandler());
        }
        public List<Client> GetClientById(int id)
        {
            string comText =
                "select *  from Clients where clientid="+id;
            return DbExecutor.Execute<Client>(ConnectionString, comText, new DbClientHandler());
        }

        public void AddClient(Client client)
        {
            string comText =
                "Insert into Clients(ClientName,ClientPhone,ClientAdress,ClientType) values('" + client.ClientName +
                "','" + client.ClientPhone + "','" + client.ClientAdress + "','" + client.ClientType + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbClientHandler());
        }

        public List<Category> GetCategoryList()
        {
            string comText =
                "select *  from Categories";
            return DbExecutor.Execute<Category>(ConnectionString, comText, new DbCategoryHandler());
        }
        public List<Category> GetCategoryById(int id)
        {
            string comText =
                "select *  from Categories where categoryid="+id;
            return DbExecutor.Execute<Category>(ConnectionString, comText, new DbCategoryHandler());
        }

        public void AddCategory(Category category)
        {
            string comText =
                "Insert into Categories(CategoryName) values('" + category.CategoryName + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbCategoryHandler());
        }
        

        public List<Seller> GetSellerList()
        {
            string comText =
                "select *  from Sellers";
            return DbExecutor.Execute<Seller>(ConnectionString, comText, new DbSellerHandler());
        }
        public List<Seller> GetSellerById(int id)
        {
            string comText =
                "select *  from Sellers where sellerid="+id;
            return DbExecutor.Execute<Seller>(ConnectionString, comText, new DbSellerHandler());
        }
        

        public void AddSeller(Seller seller)
        {
            string comText =
                "Insert into Sellers(SellerName,SELLERADRESS,SELLERPHONE) values('" + seller.SellerName + "',+'" +
                seller.SellerAddress + "',+'" + seller.SellerPhone + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbSellerHandler());
        }

        public List<Order> GetOrderList()
        {
            string comText =
                "select *  from Orders";

            return DbExecutor.Execute<Order>(ConnectionString, comText, new DbOrderHandler());
        }
        public List<Order> GetOrderById(int id)
        {
            string comText =
                "select *  from Orders where orderid="+id;
            return DbExecutor.Execute<Order>(ConnectionString, comText, new DbOrderHandler());
        }

        public void AddOrder(Order order)
        {
            string comText =
                "Insert into Orders(ORDERDATE,COMPLETIONDATE,COMPLETION,TOTALPRICE,CLIENTID,ORDERLIST) values("+
                "TRUNC(TO_DATE('" +order.OrderDate + "','MM-DD-YYYY HH:MI:SS'))," +
                "TRUNC(TO_DATE('" + order.CompletionDate + "','MM-DD-YYYY HH:MI:SS'))," +
                "+'" + order.Completion + "'+" + order.TotalPrice + "+" + order.ClientId + "+'" + order.OrderList +
                "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbOrderHandler());
        }

        public List<Stock> GetStockList()
        {
            string comText =
                "select *  from Stocks";

            return DbExecutor.Execute<Stock>(ConnectionString, comText, new DbStockHandler());
        }
        public List<Stock> GetStockById(int id)
        {
            string comText =
                "select *  from Stocks where stockid="+id;
            return DbExecutor.Execute<Stock>(ConnectionString, comText, new DbStockHandler());
        }
        public void AddStock(Stock stock)
        {
            string comText =
                "Insert into Stocks(Stockadress) values('" + stock.StockAddress + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbStockHandler());
        }
    }
}