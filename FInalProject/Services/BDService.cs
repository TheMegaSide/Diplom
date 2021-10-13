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
                "Select productid, PRODUCTNAME, PRODUCTINDEX, PRODUCTUNIT, CATEGORYNAME, SELLERNAME, STOCKADRESS, PRODUCTPRICE,PRODUCTDATE,AMOUNT from products, CATEGORIES, sellers,STOCKS where PRODUCTS.CATEGORYID=CATEGORies.CATEGORYID and SELLERS.SELLERID=PRODUCTS.SELLERID and STOCKS.STOCKID=PRODUCTS.STOCKID";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Product>(ConnectionString, comText, new DbProductHandler());
        }
        public Product GetProductById(int id)
        {
            string comText =
                "select *  from Products where Productid="+id;
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Product>(ConnectionString, comText, new DbProductHandler())[0];
        }
        public List<Product> GetProductByCategory(int category)
        {
            string comText =
                "select *  from Products where Categoryid="+category;
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Product>(ConnectionString, comText, new DbProductHandler());
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
        public void DeleteProduct(Product product)
        {
            string comText =
                "delete from Products where Productid="+product.ProductId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbProductHandler());
        }


        public List<Client> GetClientList()
        {
            string comText =
                "select *  from Clients";
            return DbExecutor.Execute<Client>(ConnectionString, comText, new DbClientHandler());
        }
        public Client GetClientById(int id)
        {
            string comText =
                "select *  from Clients where clientid="+id;
            return DbExecutor.Execute<Client>(ConnectionString, comText, new DbClientHandler())[0];
        }
        public void ClientEdit(Client client)
        {
            string comText =
                "Update clients set clientname='" + client.ClientName + "',CLIENTPHONE='" + client.ClientPhone +
                "',CLIENTADRESS='" + client.ClientAdress + "',CLIENTTYPE=" + client.ClientType + 
                " where productid=" + client.ClientId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbClientHandler());
        }

        public void AddClient(Client client)
        {
            string comText =
                "Insert into Clients(ClientName,ClientPhone,ClientAdress,ClientType) values('" + client.ClientName +
                "','" + client.ClientPhone + "','" + client.ClientAdress + "','" + client.ClientType + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbClientHandler());
        }
        public void DeleteClient(Client client)
        {
            string comText =
                "delete from Clients where clientid="+client.ClientId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbClientHandler());
        }

        public List<Category> GetCategoryList()
        {
            string comText =
                "select *  from Categories";
            return DbExecutor.Execute<Category>(ConnectionString, comText, new DbCategoryHandler());
        }
        public Category GetCategoryById(int id)
        {
            string comText =
                "select *  from Categories where categoryid="+id;
            return DbExecutor.Execute<Category>(ConnectionString, comText, new DbCategoryHandler())[0];
        }
        public void CategoryEdit(Category category)
        {
            string comText =
                "Update categories set categoryname='"+category.CategoryName+"' where categoryid="+category.CategoryId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbCategoryHandler());
        }

        public void AddCategory(Category category)
        {
            string comText =
                "Insert into Categories(CategoryName) values('" + category.CategoryName + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbCategoryHandler());
        }
        public void DeleteCategory(Category category)
        {
            string comText =
                "delete from categories where categoryid="+category.CategoryId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbCategoryHandler());
        }
        

        public List<Seller> GetSellerList()
        {
            string comText =
                "select *  from Sellers";
            return DbExecutor.Execute<Seller>(ConnectionString, comText, new DbSellerHandler());
        }
        public Seller GetSellerById(int id)
        {
            string comText =
                "select *  from Sellers where sellerid="+id;
            return DbExecutor.Execute<Seller>(ConnectionString, comText, new DbSellerHandler())[0];
        }
        

        public void AddSeller(Seller seller)
        {
            string comText =
                "Insert into Sellers(SellerName,SELLERADRESS,SELLERPHONE) values('" + seller.SellerName + "',+'" +
                seller.SellerAddress + "',+'" + seller.SellerPhone + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbSellerHandler());
        }
        public void SellerEdit(Seller seller)
        {
            string comText =
                "Update sellers set sellername='"+seller.SellerName+",SELLERADRESS="+seller.SellerAddress+",SELLERPHONE="+seller.SellerPhone+"' where sellerid="+seller.SellerId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbSellerHandler());
        }
        public void SellerDelete(Seller seller)
        {
            string comText =
                "delete from sellers  where sellerid="+seller.SellerId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbSellerHandler());
        }
        

        public List<Order> GetOrderList()
        {
            string comText =
                "select o.ORDERDATE,o.COMPLETIONDATE,o.COMPLETION,o.TOTALPRICE, c.CLIENTNAME, o.\"OrderList\".ID, p.PRODUCTname, o.\"OrderList\".AMOUNT "+  
                "from orders o, CLIENTS c, PRODUCTS p where c.CLIENTID=o.CLIENTID and p.PRODUCTID=o.\"OrderList\".PRODUCTID";

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
                "Insert into Orders(orderid, ORDERDATE,COMPLETIONDATE,COMPLETION,TOTALPRICE,CLIENTID,ORDERLIST) values("+
                "TRUNC(TO_DATE('" +order.OrderDate + "','MM-DD-YYYY HH:MI:SS'))," +
                "TRUNC(TO_DATE('" + order.CompletionDate + "','MM-DD-YYYY HH:MI:SS'))," +
                "'" + order.Completion + "'," + order.TotalPrice + "," + order.ClientId + ",(1," + order.productid+"," +order.amount+
                ")) ";
        
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