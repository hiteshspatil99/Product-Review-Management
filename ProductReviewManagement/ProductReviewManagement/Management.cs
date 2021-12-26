using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    public class Management
    {
        DataTable dataTable = new DataTable();
        public static void Display(List<ProductReview> ProductReviewList)
        {
            foreach (ProductReview product in ProductReviewList)
            {
                Console.WriteLine("Productid:" + product.ProductId + "UserId:" + product.UserId + "Ratting:" + product.Ratting
                    + "Review" + product.Review + "IsLike" + product.IsLike);
            }
        }
        public static void SelectTopRatingsRecords(List<ProductReview> ProductReviewList)
        {
            var records = (from product in ProductReviewList orderby product.Ratting descending select product).Take(3);
            foreach (ProductReview product in records)
            {
                Console.WriteLine("ProductId : " + product.ProductId + " UserId : " + product.UserId + " Ratting : " + product.Ratting + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        public static void SelectRecordsBasedOnProductId(List<ProductReview> ProductReviewList)
        {
            var records = (ProductReviewList.Where(product => product.Ratting > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9))).ToList();
            foreach (ProductReview product in records)
            {
                Console.WriteLine("ProductId : " + product.ProductId + " UserId : " + product.UserId + " Rating : " + product.Ratting + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        public static void CountingProductId(List<ProductReview> ProductReviewList)
        {
            var records = ProductReviewList.GroupBy(product => product.ProductId).Select(x => new { ProductId = x.Key, count = x.Count() });
            foreach (var item in records)
            {
                Console.WriteLine("ProductId : " + item.ProductId + " " + "Count:" + item.count);
            }
        }
        public static void RetriveProductIdAndReviw(List<ProductReview> ProductReviewList)
        {
            var record = ProductReviewList.Select(product => new { ProductId = product.ProductId, Review = product.Review }).ToList();
            foreach (var item in record)
            {
                Console.WriteLine("ProductId : " + item.ProductId + " " + "Review:" + item.Review);


            }
        }
        public static void SkipTopRatingsRecords(List<ProductReview> ProductReviewList)
        {
            var records = (from product in ProductReviewList orderby product.Ratting descending select product).Skip(5);
            foreach (ProductReview product in records)
            {
                Console.WriteLine("ProductId : " + product.ProductId + " UserId : " + product.UserId + " Rating : " + product.Ratting + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        public static void ProductReviewdataTable(List<ProductReview> ProductReviewList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId").DataType = typeof(Int32);
            dataTable.Columns.Add("UserId").DataType = typeof(Int32);
            dataTable.Columns.Add("Ratting").DataType = typeof(int);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike").DataType = typeof(bool);
            foreach (var item in ProductReviewList)
            {
                dataTable.Rows.Add(item.ProductId, item.UserId, item.Ratting, item.Review, item.IsLike);
            }
            var productTable = from products in dataTable.AsEnumerable() select products;
            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserID") + " " +
                  product.Field<int>("Ratting") + " " + product.Field<string>("Review") + " " + product.Field<bool>("IsLike"));
            }
        }
        public static void RetrieveRecordsWhereIslikeTrue(List<ProductReview> ProductReviewList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId").DataType = typeof(Int32);
            dataTable.Columns.Add("UserId").DataType = typeof(Int32);
            dataTable.Columns.Add("Ratting").DataType = typeof(Int32);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike").DataType = typeof(bool);
            foreach (var item in ProductReviewList)
            {
                dataTable.Rows.Add(item.ProductId, item.UserId, item.Ratting, item.Review, item.IsLike);
            }
            var productTable = from products in dataTable.AsEnumerable()
                               where products.Field<bool>("IsLike").Equals(true)
                               select products;

            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserId") + " " + product.Field<int>("Ratting") + " " + product.Field<string>("Review") + " " + product.Field<bool>("IsLike"));
            }
        }
        public static void AveragePerProductId(List<ProductReview> Review)
        {
            var recordData = Review.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, AverageRatting = x.Average(x => x.Ratting) });
            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductId + "   " + list.AverageRatting);
            }
        }
        public static void RetrieveRecordsWhereReviewNice(List<ProductReview> ProductReviewList)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId").DataType = typeof(Int32);
            dataTable.Columns.Add("UserId").DataType = typeof(Int32);
            dataTable.Columns.Add("Ratting").DataType = typeof(Int32);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike").DataType = typeof(bool);
            foreach (var item in ProductReviewList)
            {
                dataTable.Rows.Add(item.ProductId, item.UserId, item.Ratting, item.Review, item.IsLike);
            }
            var productTable = from products in dataTable.AsEnumerable()
                               where products.Field<string>("Review") == "nice"
                               select products;

            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserId") + " " + product.Field<int>("Ratting") + " " + product.Field<string>("Review") + " " + product.Field<bool>("IsLike"));
            }
        }
        public static void RetriveRecordsFromDataTableWhereUserId(List<ProductReview> ProductReviewlist)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId").DataType = typeof(Int32);
            dataTable.Columns.Add("UserId").DataType = typeof(Int32);
            dataTable.Columns.Add("Ratting").DataType = typeof(Int32);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("IsLike").DataType = typeof(bool);
            foreach (var item in ProductReviewlist)
            {
                dataTable.Rows.Add(item.ProductId, item.UserId, item.Ratting, item.Review, item.IsLike);
            }
            var productTable = from product in dataTable.AsEnumerable() where product.Field<int>("UserId") == 10 select product;

            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserId") + " " + product.Field<int>("Ratting") + " " + product.Field<string>("Review") + " " + product.Field<bool>("IsLike"));
            }
        }

    }
}
