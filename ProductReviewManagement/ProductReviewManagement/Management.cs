using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class Management
    {
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
        public static void SelectRecordsBasedOnProductId(List<ProductReview> list)
        {
            var records = (list.Where(product => product.Ratting > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9))).ToList();
            foreach (ProductReview product in records)
            {
                Console.WriteLine("ProductId : " + product.ProductId + " UserId : " + product.UserId + " Rating : " + product.Ratting + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
        public static void CountingProductId(List<ProductReview> list)
        {
            var records = list.GroupBy(product => product.ProductId).Select(x => new { ProductId = x.Key, count = x.Count() });
            foreach (var item in records)
            {
                Console.WriteLine("ProductId : " + item.ProductId + " " + "Count:" + item.count);
            }
        }
        public static void RetriveProductIdAndReviw(List<ProductReview> list)
        {
            var record = list.Select(product => new { ProductId = product.ProductId, Review = product.Review }).ToList();
            foreach (var item in record)
            {
                Console.WriteLine("ProductId : " + item.ProductId + " " + "Review:" + item.Review);


            }
        }
        public static void SkipTopRatingsRecords(List<ProductReview> list)
        {
            var records = (from product in list orderby product.Ratting descending select product).Skip(5);
            foreach (ProductReview product in records)
            {
                Console.WriteLine("ProductId : " + product.ProductId + " UserId : " + product.UserId + " Rating : " + product.Ratting + " Review : " + product.Review + " IsLike : " + product.IsLike);
            }
        }
    }
}
