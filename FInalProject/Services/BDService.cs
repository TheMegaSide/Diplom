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
            ConnectionString = configuration.GetConnectionString("NpgsqlConnection");
        }

        public List<Car> GetCarsList()
        {
            string comText =
                "Select * from cars;";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Car>(ConnectionString, comText, new DbCarHandler());
        }
        public Car GetCarById(string id)
        {
            string comText =
                "Select * from cars where  govnum='"+id+"'";
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Car>(ConnectionString, comText, new DbCarHandler())[0];
        }
        public List<Product> GetProductByCategory(int category)
        {
            string comText =
                "select *  from Products where Categoryid="+category;
            Console.WriteLine($"INFO:{comText}");
            return DbExecutor.Execute<Product>(ConnectionString, comText, new DbProductHandler());
        }
        public void CarEdit(Car car)
        {
            string comText =
                "Update cars set govnum="+"'" + car.govnum + "',creator='" + car.creater +
                "',type='" + car.type + "',model='" + car.model + "',carvalue=" +
                car.valueOfCar +
                ",fueltype='" + car.fuelType + "',tankvalue=" + car.valueOfTank + ",glonasnum=" +
                 + car.glonasNum + 
                ",platonnum=" + car.platonNum +",owner='"+car.owner+"',location='"+car.location+"',runned="+car.runned+
                " where govnum="+"'" + car.govnum+"'";
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbCarHandler());
        }

        public void AddCar(Car car)
        {
            string comText =
                "Insert into cars(govnum,creator,type,model,carvalue,fueltype,tankvalue,glonasnum,platonnum,owner,location,runned) values('" +
                car.govnum + "','" + car.creater + "','" + car.type + "','"
                + car.model + "'," + car.valueOfCar + ",'" + car.fuelType + "'," + car.valueOfTank +
                "," + car.glonasNum + "," + car.platonNum + ",'"+car.owner+"','"+car.location+"',"+car.runned+") ";

            DbExecutor.Execute(ConnectionString, comText, new DbCarHandler());
        }
        public void DeleteCar(Car car)
        {
            string comText =
                "delete from cars where govnum='"+car.govnum+"'";
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
                "',CLIENTADRESS='" + client.ClientAdress + "',CLIENTTYPE='" + client.ClientType + 
                "' where clientid=" + client.ClientId;
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
            Console.WriteLine($"INFO:{comText}");
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
                "Update sellers set sellername='"+seller.SellerName+"',SELLERADRESS='"+seller.SellerAddress+"',SELLERPHONE='"+seller.SellerPhone+"' where sellerid="+seller.SellerId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbSellerHandler());
        }
        public void DeleteSeller(Seller seller)
        {
            string comText =
                "delete from sellers  where sellerid="+seller.SellerId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbSellerHandler());
        }
        

        public List<Order> GetOrderList()
        {
            string comText =
                "select * from orders o, CLIENTS c, PRODUCTS p where c.CLIENTID=o.CLIENTID and p.PRODUCTID=o.\"Productid\"";

            return DbExecutor.Execute<Order>(ConnectionString, comText, new DbOrderHandler());
        }
        public Order GetOrderById(int id)
        {
            string comText =
                "select * from orders o, CLIENTS c, PRODUCTS p where c.CLIENTID=o.CLIENTID and p.PRODUCTID=o.\"Productid\" and orderid="+id;
            return DbExecutor.Execute<Order>(ConnectionString, comText, new DbOrderHandler())[0];
        }

        public void AddOrder(Order order)
        {
            string comText =
                "Insert into Orders(ORDERDATE,COMPLETIONDATE,COMPLETION,TOTALPRICE,CLIENTID,\"Productid\",amount) values(" +
                "TRUNC(TO_DATE('" + order.OrderDate + "','DD-MM-YYYY HH24:MI:SS'))," +
                "TRUNC(TO_DATE('" + order.CompletionDate + "','DD-MM-YYYY HH24:MI:SS'))," +
                "'" + order.Completion + "'," + order.TotalPrice +
                ",CLIENTID=(Select CLIENTID from CLIENTS  where CLIENTNAME='" + order.CLientname +
                "') ,\"Productid\"=(Select p.productid from products p where productname='" + order.productname +
                "'),amount=" + order.amount+")" ;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbOrderHandler());
        }
        public void EditOrder(Order order)
        {
            string comText =
                "update orders set orderid="+order.OrderId+", orderdate="+
                "TRUNC(TO_DATE('" +order.OrderDate + "','DD-MM-YYYY HH24:MI:SS')), completiondate=" +
                "TRUNC(TO_DATE('" + order.CompletionDate + "','DD-MM-YYYY HH24:MI:SS')),completion=" +
                "'" + order.Completion + "',totalprice=" + order.TotalPrice + ",CLIENTID=(Select CLIENTID from CLIENTS  where CLIENTNAME='" 
                + order.CLientname + "') ,\"Productid\"=(Select p.productid from products p where productname='"+order.productname +
                "'),amount="+order.amount+" where orderid="+order.OrderId+" ";
            
            Console.WriteLine($"INFO:{comText}");
        
            DbExecutor.Execute(ConnectionString, comText, new DbOrderHandler());
        }
        public void DeleteOrder(Order order)
        {
            string comText =
                "delete from Orders where orderid="+order.OrderId;
        
            DbExecutor.Execute(ConnectionString, comText, new DbOrderHandler());
        }

        public List<Stock> GetStockList()
        {
            string comText =
                "select *  from Stocks";

            return DbExecutor.Execute<Stock>(ConnectionString, comText, new DbStockHandler());
        }
        public Stock GetStockById(int id)
        {
            string comText =
                "select *  from Stocks where stockid="+id;
            return DbExecutor.Execute<Stock>(ConnectionString, comText, new DbStockHandler())[0];
        }
        public void AddStock(Stock stock)
        {
            string comText =
                "Insert into Stocks(Stockadress) values('" + stock.StockAddress + "') ";

            DbExecutor.Execute(ConnectionString, comText, new DbStockHandler());
        }
        public void EditStock(Stock stock)
        {
            string comText =
                "update Stocks set STOCKADRESS='" + stock.StockAddress + "' where stockid= "+stock.StockId;
            Console.WriteLine($"INFO:{comText}");
            DbExecutor.Execute(ConnectionString, comText, new DbStockHandler());
        }
        public void DeleteStock(Stock stock)
        {
            string comText =
                "delete from Stocks where stockid=" + stock.StockId ;

            DbExecutor.Execute(ConnectionString, comText, new DbStockHandler());
        }
    }
}