Imports BookingVbNetApi.Model
Namespace Repository
    Public Interface IBoexRepoository
        Function FindAllBookingOrderDetailExtra() As List(Of Boex)

        Function FindBoexByID(ByVal id As Int32) As Boex

        Function CreateNewBoex(boex As Boex) As Boex

        Function DeleteBoex(ByVal id As Int32) As Int32

        Function UpdateBoexByID(BoexId As Integer,
                                  BoexPrice As Double,
                                  BoexQty As Integer,
                                  BoexsubTotal As Double,
                                  BoexMeasureUnit As String,
                                  BoexBordeId As Integer,
                                  BoexPritId As Integer,
                           Optional showCommand As Boolean = False) As Boolean


    End Interface
End Namespace
