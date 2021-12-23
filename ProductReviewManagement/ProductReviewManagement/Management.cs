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
        //public void SelectedRecords(List<ProductReview> ProductReviewList)
        //{
        //    var records = List.groupBy(x => x.ProductId).select(x => new { ProductId = x.ProductId, Count = x.Count() });
        //    foreach (var data in records)
        //    {
        //        Console.WriteLine(data.Count);
        //    }
        //}
        //public void RetriveProductIdAndReview(List<ProductReview> Review)
        //{
        //    var recordedData = from productReviews in Review 
        //                       select new { productReviews.ProductId, productReviews.Review }; 
        //    foreach (var list in recordedData)
        //    {
        //        Console.WriteLine("ProductId : " + list.ProductId + "  " +  " Review : " + list.Review + ");
    }
}   
