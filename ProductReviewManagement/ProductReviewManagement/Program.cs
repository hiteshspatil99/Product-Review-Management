﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management Problem Statement");

            List<ProductReview> ProductReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId =1, UserId=1, Ratting= 5 ,Review= "Good", IsLike= true},
                new ProductReview(){ProductId =2, UserId=1, Ratting= 4 ,Review= "Good", IsLike= true},
                new ProductReview(){ProductId =3, UserId=2, Ratting= 3, Review= "nice", IsLike= true},
                new ProductReview(){ProductId =4, UserId=2, Ratting= 1, Review= "bad", IsLike= false},
                new ProductReview(){ProductId =5, UserId=3, Ratting= 2, Review= "Moderate",IsLike= false},
                new ProductReview(){ProductId =6, UserId=4, Ratting= 3, Review= "nice", IsLike= true},
                new ProductReview(){ProductId =7, UserId=5, Ratting= 1, Review= "bad", IsLike= false},
                new ProductReview(){ProductId =8, UserId=5, Ratting= 2, Review= "Moderate", IsLike= false}
            };
            foreach (var List in ProductReviewList)
            {
                Console.WriteLine("ProductId:-" + List.ProductId + "" + "UserId:-" + List.UserId + "" + "Ratting:-" + List.Ratting + "" + "Review:-" + List.Review + "" + "IsLike:-" + List.IsLike);
            }
        }
    }
}