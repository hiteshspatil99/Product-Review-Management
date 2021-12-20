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
    }
}
