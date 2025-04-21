using EntityProject.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityProject.repositories
{
    public interface IPaymentOutsideOfFlutterwave
    {
        void AddIPaymentOutsideOfFlutterwave(PaymentNotificationOutsideOfFlutterwave paymentOutsideOfFlutterwave);
        PaymentNotificationOutsideOfFlutterwave GetIPaymentOutsideOfFlutterwaveByUserNameAndUserType(string UserName, string UserType,string PaymentReference);
    }
}
