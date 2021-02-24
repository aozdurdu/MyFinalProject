using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "System in maintenance mode";
        public static string ProductsListed = "Product listed";
        public static string ProductCountOfCategoryError = "Exceed the max number in the related category";
        public static string ProductNameAlreadyExists = "The product name already exists in db";
        public static string CategoryLimitExceded = "Category limit is exceded, new product couldn't be added.";
    }
}
