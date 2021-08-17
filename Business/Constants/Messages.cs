using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added.";
        public static string CarDeleted = "Car deleted.";
        public static string CarUpdated = "Car updated.";
        public static string CarNameValid = "Car name is invalid";

        public static string MessageListed = "Listed.";

        public static string BrandAdded = "Brand added.";
        public static string BrandDeleted = "Brand deleted.";
        public static string BrandUpdated = "Brand updated.";

        public static string ColorAdded = "Color added.";
        public static string ColorDeleted = "Color deleted.";
        public static string ColorUpdated = "Color updated.";

        public static string CustomerAdded = "Customer added.";
        public static string CustomerDeleted = "Customer deleted.";
        public static string CustomerUpdated = "Customer updated.";

        public static string UserAdded = "User added.";
        public static string UserDeleted = "User deleted.";
        public static string UserUpdated = "User updated.";

        public static string RentalAdded = "Rental added.";
        public static string RentalDeleted = "Rental deleted.";
        public static string RentalUpdated = "Rental updated.";
        public static string RentalFailed = "Since the vehicle has not been delivered yet, it cannot be rented";


        public static string ImageLimitExceded = "Exceeded the number of images that can be added";
        public static string CarImageAdded = "Image added";
        public static string CarImageDeleted = "Image deleted.";
        public static string CarImageUpdated = "Image updated.";
        public static string NotFound ="Not Found";

        public static string AuthorizationDenied = "You are not authorized.";
        public static string UserRegistered = "Registered.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Password error.";
        public static string SuccessfulLogin = "Successful login.";
        public static string UserAlreadyExists = "User exists.";
        public static string AccessTokenCreated = "Token has been created.";
    }
}
