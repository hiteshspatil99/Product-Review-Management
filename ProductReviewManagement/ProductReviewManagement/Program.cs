using System;
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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select step Number to Execute the Program :- \n 1.Display Data \n 2.Retrive Data \n 3.View Data on the basis of ProductId \n 4.Count ProductId \n 5. Get Only Data ProductId & Review " +
                    "\n 6. Skipping Five Top records \n 7. Product Data Table \n 8. Perticular Retrieve Records Islike \n 9. Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Management.Display(ProductReviewList);
                        break;

                    case 2:
                        Management.SelectTopRatingsRecords(ProductReviewList);
                        break;

                    case 3:
                        Management.SelectRecordsBasedOnProductId(ProductReviewList);
                        break;

                    case 4:
                        Management.CountingProductId(ProductReviewList);
                        break;

                    case 5:
                        Management.RetriveProductIdAndReviw(ProductReviewList);
                        break;

                    case 6:
                        Management.SkipTopRatingsRecords(ProductReviewList);
                        break;

                    case 7:
                        Management.ProductReviewdataTable(ProductReviewList);
                        break;

                    case 8:
                        Management.RetrieveRecordsWhereIslikeTrue(ProductReviewList);
                        break;

                    case 9:
                        flag = false;
                        break;
                }

            }
        }
    }
}

