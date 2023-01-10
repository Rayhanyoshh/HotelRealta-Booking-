using BookingVbNetApi;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.Reflection;

namespace BookingClient
{
    internal class Program
    {
        private static IConfiguration Configuration;
        static void Main(string[] args)
        {
            BuildConfig();
            //_bookingVbApi.SayHello();

            IBookingVbApi _bookingVbApi = new BookingVbApi(Configuration.GetConnectionString("HotelRealtaDS"));

            ////FIND ALL BOOKING
            //var listOrder = _bookingVbApi.RepositoryManager.Booking.FindAllBookingOrders();
            //foreach (var item in listOrder)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine();

            //FIND BOOKING BY ID
            //Console.Write("Enter Booking Order Id : ");
            //var enterNum = Convert.ToInt32(Console.ReadLine());
            //var BoorById = _bookingVbApi.RepositoryManager.Booking.FindOrderById(enterNum);
            //Console.WriteLine($"Boor ID has Already Found = {BoorById}");

            //CREATE BOOKING
            //Console.Write("Input ID : ");
            //var inputID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Order Number : ");
            //var inputOrderNumber = Console.ReadLine();
            //Console.Write("Input Order Date : ");
            //var inputOrderDate = (Console.ReadLine());
            //Console.Write("Input Arrival Date : ");
            //var inputArrivalDate = Console.ReadLine();
            //Console.Write("Input Total Room : ");
            //var inputTotalRoom = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Total Guest : ");
            //var inputTotalGuest = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Discount : ");
            //var inputDiscount = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Input Total Tax : ");
            //var inputTotalTax = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Input Total Amount : ");
            //var inputTotalAmount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input DP : ");
            //var inputDP = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Payment Type : ");
            //var inputPayType = Console.ReadLine();
            //Console.Write("Input is Paid or Not : ");
            //var inputIsPaid = Console.ReadLine();
            //Console.Write("Input Order Type : ");
            //var inputOrderType = Console.ReadLine();
            //Console.Write("Input Cardnumber of Payment : ");
            //var inputCardnumber = Console.ReadLine();
            //Console.Write("Input Member Type : ");
            //var inputMemberType = Console.ReadLine();
            //Console.Write("Input Order Status : ");
            //var inputStatus = Console.ReadLine();
            //Console.Write("Input Order User ID  : ");
            //var inputUserID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Order Hotel ID : ");
            //var inputHotelID = Convert.ToInt32(Console.ReadLine());


            //var NewOrder = _bookingVbApi.RepositoryManager.Booking.CreateNewOrder(new BookingVbNetApi.Model.Booking_orders
            //{
            //    BoorId = inputID,
            //    Boor_order_number = inputOrderNumber,
            //    Boor_order_date = inputOrderDate,
            //    Boor_arrival_date = inputArrivalDate,
            //    Boor_total_room = inputTotalRoom,
            //    Boor_total_guest = inputTotalGuest,
            //    Boor_discount = inputDiscount,
            //    Boor_total_tax = inputTotalTax,
            //    Boor_total_amount = inputTotalAmount,
            //    Boor_down_payment = inputDP,
            //    Boor_pay_type = inputPayType,
            //    Boor_is_paid = inputIsPaid,
            //    Boor_type = inputOrderType,
            //    Boor_cardnumber = inputCardnumber,
            //    Boor_member_type = inputMemberType,
            //    Boor_status = inputStatus,
            //    Boor_user_id = inputUserID,
            //    Boor_hotel_id = inputHotelID,

            //});
            //Console.WriteLine($"New Booking Order : {NewOrder}");

            ////Delete Row
            //Console.WriteLine("Input Row number to delete : ");
            //var inputDeleteRow = Convert.ToInt32(Console.ReadLine());
            //var rowDelete = _bookingVbApi.RepositoryManager.Booking.DeleteBookingByID(inputDeleteRow);
            //Console.WriteLine($"Order ID {inputDeleteRow} sudah terhapus");


            //UPDATE ROW BY ID
            //Console.Write(" WHERE Input ID : ");
            //var inputID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Order Date : ");
            //var inputOrderDate = (Console.ReadLine());
            //Console.Write("Input Arrival Date : ");
            //var inputArrivalDate = Console.ReadLine();
            //Console.Write("Input Total Room : ");
            //var inputTotalRoom = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Total Guest : ");
            //var inputTotalGuest = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Discount : ");
            //var inputDiscount = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Input Total Tax : ");
            //var inputTotalTax = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Input Total Amount : ");
            //var inputTotalAmount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input DP : ");
            //var inputDP = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Payment Type : ");
            //var inputPayType = Console.ReadLine();
            //Console.Write("Input is Paid or Not : ");
            //var inputIsPaid = Console.ReadLine();
            //Console.Write("Input Order Type : ");
            //var inputOrderType = Console.ReadLine();
            //Console.Write("Input Cardnumber of Payment : ");
            //var inputCardnumber = Console.ReadLine();
            //Console.Write("Input Member Type : ");
            //var inputMemberType = Console.ReadLine();
            //Console.Write("Input Order Status : ");
            //var inputStatus = Console.ReadLine();
            //Console.Write("Input Order User ID  : ");
            //var inputUserID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Order Hotel ID : ");
            //var inputHotelID = Convert.ToInt32(Console.ReadLine());


            //var updateBookkingOrder = _bookingVbApi.RepositoryManager.Booking.UpdateBookingById(inputID, inputOrderDate, inputArrivalDate, inputTotalRoom, inputTotalGuest, inputDiscount, inputTotalTax, inputTotalAmount, inputDP, inputPayType, inputIsPaid, inputOrderType, inputCardnumber, inputMemberType, inputStatus, inputUserID, inputHotelID, true);
            //var bookingUpdateResult = _bookingVbApi.RepositoryManager.Booking.FindOrderById(inputID);
            //Console.WriteLine($"Booking Order dengan ID = {inputID} telah diUpdate");
            //Console.WriteLine(bookingUpdateResult);

            //var updateBoorBySp = _bookingVbApi.RepositoryManager.Booking.UpdateBookingBySp(16,"","","");

            //Console.WriteLine($" updated data :{updateBoorBySp}");

            //Console.Write($"Masukkan id :");
            //var inputId  = Convert.ToInt32(Console.ReadLine());

            //var rowToupdate = _bookingVbApi.RepositoryManager.Booking.FindOrderById(inputId);
            //Console.WriteLine(rowToupdate);

            //}

            //FIND ALL BORDE
            //var AllboorList = _bookingVbApi.RepositoryManager.Borde.FindAllBorde();
            //foreach (var item in AllboorList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine();


            //FIND ALL BOEX
            //var AllBoexList = _bookingVbApi.RepositoryManager.Boex.FindAllBookingOrderDetailExtra();
            //foreach (var item in AllBoexList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine();

            //FIND BOEX BY ID
            //Console.Write("Enter Booking Order Detail Extra Id : ");
            //var enterNum = Convert.ToInt32(Console.ReadLine());
            //var BoexById = _bookingVbApi.RepositoryManager.Boex.FindBoexByID(enterNum);
            //Console.WriteLine($"Boor ID has Already Found = {BoexById}" +
            //    $"");


            //CREATE NEW BOEX
            //Console.Write("Input Boex ID : ");
            //var inputboexID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Boex Price : ");
            //var inputboexPrice = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Boex Quantity : ");
            //var inputboexQty = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Boex Subtotal Price : ");
            //var inputboexSubtotal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input Boex Measure Unit : ");
            //var inputboexMeasureUnit = Console.ReadLine();
            //Console.Write("Input Boex Borde Id : ");
            //var inputboexBordeId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Boex Price Item ID : ");
            //var inputboexPritId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //var NewBoex = _bookingVbApi.RepositoryManager.Boex.CreateNewBoex(new BookingVbNetApi.Model.Boex
            //{
            //    Boex_id = inputboexID,
            //    Boex_price = inputboexPrice,
            //    Boex_qty = inputboexQty,
            //    Boex_subtotal = inputboexSubtotal,
            //    Boex_measure_unit = inputboexMeasureUnit,
            //    Boex_borde_id = inputboexBordeId,
            //    Boex_prit_id = inputboexPritId
            //});
            //Console.WriteLine($"" +
            //    $"New Boex has Already done with ID : {NewBoex}" +
            //    $"");


            //DELETE BOEX ROW
            //Console.Write("Input Row number to delete : ");
            //var inputDeleteRow = Convert.ToInt32(Console.ReadLine());
            //var rowDelete = _bookingVbApi.RepositoryManager.Boex.DeleteBoex(inputDeleteRow);
            //Console.WriteLine($"Order ID {inputDeleteRow} sudah terhapus");



            //UPDATE BOEX BY ID
            Console.Write("Input Boex ID to Update : ");
            var inputboexID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Update Boex Price : ");
            var inputboexPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Update Boex Quantity : ");
            var inputboexQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Update Boex Subtotal Price : ");
            var inputboexSubtotal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Update Boex Measure Unit : ");
            var inputboexMeasureUnit = Console.ReadLine();
            Console.Write("Update Boex Borde Id : ");
            var inputboexBordeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Update Boex Price Item ID : ");
            var inputboexPritId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var updateBoexByID = _bookingVbApi.RepositoryManager.Boex.UpdateBoexByID(inputboexID,inputboexPrice,inputboexQty,inputboexSubtotal,inputboexMeasureUnit,inputboexBordeId,inputboexPritId,true);
            var boexUpdateResult = _bookingVbApi.RepositoryManager.Boex.FindBoexByID(inputboexID);
            Console.WriteLine($"Booking Order Detail Extra dengan ID = {inputboexID} telah diUpdate");
            Console.WriteLine();
            Console.WriteLine(boexUpdateResult);









            static void BuildConfig()
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
                Configuration = builder.Build(); //Container menyimpan Configuration
                //Console.WriteLine(Configuration.GetConnectionString("HotelRealtaDS"));
            }

        }
    }
}
