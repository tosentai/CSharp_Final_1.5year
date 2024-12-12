using Final.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace Final.UserInterface
{
    public class BookingNotificationService
    {
        private readonly FinalContext _context;

        public BookingNotificationService(FinalContext context)
        {
            _context = context;
        }

        private const string AccountSid = "";
        private const string AuthToken = "";
        private const string FromPhoneNumber = "";

        public void SendBookingNotification(int bookingId)
        {
            var booking = _context.Customers.FirstOrDefault(c => c.Id == bookingId);

            if (booking == null || string.IsNullOrEmpty(booking.Contact))
            {
                throw new Exception("Booking or contact number not found.");
            }

            TwilioClient.Init(AccountSid, AuthToken);

            string messageBody = $"Dear {booking.FullName},\n\n" +
                     $"Your booking (ID: {booking.BookId}) has been confirmed. Thank you!\n\n" +
                     $"Booking Details:\n" +
                     $"- Room: {booking.RoomID}\n" +
                     $"- Price: {booking.Price:C}\n" +
                     $"- Status: {booking.StatusPayment}\n" +
                     $"- Check-in Date: {booking.DateFrom:yyyy-MM-dd}\n" +
                     $"- Check-out Date: {booking.DateTo:yyyy-MM-dd}\n\n" +
                     $"If you have any questions or need to modify your booking, please don't hesitate to contact us.\n\n" +
                     $"We look forward to hosting you!\n\n" +
                     $"Best regards,\n" +
                     $"Your Booking Team";

            try
            {
                var message = MessageResource.Create(
                    to: new PhoneNumber(booking.Contact),
                    from: new PhoneNumber(FromPhoneNumber),
                    body: messageBody
                );

                Console.WriteLine($"Message sent successfully. SID: {message.Sid}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending SMS: {ex.Message}");
            }

        }
    }
}