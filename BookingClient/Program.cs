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
            //Console.Write("Input Boex ID to Update : ");
            //var inputboexID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Update Boex Price : ");
            //var inputboexPrice = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Update Boex Quantity : ");
            //var inputboexQty = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Update Boex Subtotal Price : ");
            //var inputboexSubtotal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Update Boex Measure Unit : ");
            //var inputboexMeasureUnit = Console.ReadLine();
            //Console.Write("Update Boex Borde Id : ");
            //var inputboexBordeId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Update Boex Price Item ID : ");
            //var inputboexPritId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //var updateBoexByID = _bookingVbApi.RepositoryManager.Boex.UpdateBoexByID(inputboexID,inputboexPrice,inputboexQty,inputboexSubtotal,inputboexMeasureUnit,inputboexBordeId,inputboexPritId,true);
            //var boexUpdateResult = _bookingVbApi.RepositoryManager.Boex.FindBoexByID(inputboexID);
            //Console.WriteLine($"Booking Order Detail Extra dengan ID = {inputboexID} telah diUpdate");
            //Console.WriteLine();
            //Console.WriteLine(boexUpdateResult);

            //ALL SPECIAL OFFERS LIST
            //var AllSpofList = _bookingVbApi.RepositoryManager.Spof.FindAllSpecialOffers();
            //foreach (var item in AllSpofList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine();

            //SPECIAL OFFERS BY ID
            //Console.Write("Enter Special Offers Id : ");
            //var enterNum = Convert.ToInt32(Console.ReadLine());
            //var SpofById = _bookingVbApi.RepositoryManager.Spof.FindSpecialOffersById(enterNum);
            //Console.WriteLine($"Boor ID has Already Found = {SpofById}" +
            //    $"");


            // CREATE NEW SPECIAL OFFERS
            //Console.WriteLine("-------------CREATE NEW SPECIAL OFFER------------------");
            //Console.Write("Input Spof ID : ");
            //var inputSpofID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Spof Name : ");
            //var inputspofName = Console.ReadLine();
            //Console.Write("Input Spof Description : ");
            //var inputspofDesc = Console.ReadLine();
            //Console.Write("Input Special Offers Type : ");
            //var inputspofType = Console.ReadLine();
            //Console.Write("Input Spof Discount : ");
            //var inputspofDiscount = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input Spof Start Date : ");
            //var inputspofStartDate = Console.ReadLine();
            //Console.Write("Input Spof End Date : ");
            //var inputspofEndDate = Console.ReadLine();
            //Console.Write("Input Spof Min Order :");
            //var inputspofMinQty = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Spof Max Order : ");
            //var inputspofMaxQty = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Spof Modified Date : ");
            //Console.WriteLine("---------------------------------------------------------");
            //var inputspofModifiedDate = Console.ReadLine();
            //var NewSpof = _bookingVbApi.RepositoryManager.Spof.CreateNewSpecialOffers(new BookingVbNetApi.Model.Spof
            //{
            //    Spof_id = inputSpofID,
            //    Spof_name = inputspofName,
            //    Spof_description = inputspofDesc,
            //    Spof_type = inputspofType,
            //    Spof_discount = inputspofDiscount,
            //    Spof_start_date = inputspofStartDate,
            //    Spof_end_date = inputspofEndDate,
            //    Spof_min_qty = inputspofMinQty,
            //    Spof_max_qty = inputspofMaxQty,
            //    Spof_modified_date = inputspofModifiedDate
            //});
            //Console.WriteLine($"" +
            //    $"New Boex has Already done with ID : {NewSpof}" +
            //    $"");


            // DELETE SPOF BY ID
            //Console.WriteLine("--------DELETE SPECIAL OFFERS----------");
            //Console.Write("Input Special Offer Id to delete : ");
            //var inputDeleteRow = Convert.ToInt32(Console.ReadLine());
            //var rowDelete = _bookingVbApi.RepositoryManager.Spof.DeleteSpecialOffersByID(inputDeleteRow);
            //Console.WriteLine($"Order ID {inputDeleteRow} sudah terhapus");


            //UPDATE SPOF BY ID
            Console.Write("Input Spof ID to Update : ");
            var inputSpofId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Update Spof Name: ");
            var inputSpofName = Console.ReadLine();
            Console.Write("Update Spof Description : ");
            var inputSpofDescription = Console.ReadLine();
            Console.Write("Update Spof Type : ");
            var inputSpofType = Console.ReadLine();
            Console.Write("Update Spof Discount : ");
            var inputspofDiscount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Update Spof Start Date : ");
            var inputspofStartDate = Console.ReadLine();
            Console.Write("Update Spof End Date : ");
            var inputspofEndDate = Console.ReadLine();
            Console.Write("Update Spof Min Qty : ");
            var inputSpofMinQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Update Spof Max Qty : ");
            var inputspofMaxQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Update Spof Modified Date : ");
            var inputspofModDate = Console.ReadLine();
            Console.WriteLine();
            var updateSpofId = _bookingVbApi.RepositoryManager.Spof.UpdateSpecialOffersById(inputSpofId, inputSpofName, inputSpofDescription, inputSpofType, inputspofDiscount, inputspofStartDate, inputspofEndDate, inputSpofMinQty, inputspofMaxQty, inputspofModDate, true);
            var spofUpdateResult = _bookingVbApi.RepositoryManager.Spof.FindSpecialOffersById(inputSpofId);
            Console.WriteLine($"Booking Order Detail Extra dengan ID = {inputSpofId} telah diUpdate");
            Console.WriteLine();
            Console.WriteLine(spofUpdateResult);







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
