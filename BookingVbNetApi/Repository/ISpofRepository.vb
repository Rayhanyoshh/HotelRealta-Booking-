Imports BookingVbNetApi.Model

Namespace Repository
    Public Interface ISpofRepository
        Function FindAllSpecialOffers() As List(Of Spof)

        Function FindSpecialOffersById(ByVal id As Int32) As Spof

        Function CreateNewSpecialOffers(specialOffers As Spof) As Spof

        Function DeleteSpecialOffersByID(ByVal id As Int32) As Int32

        Function UpdateSpecialOffersById(Spofid As Integer,
                                         SpofName As String,
                                         SpofDesc As String,
                                         SpofType As String,
                                         SpofDiscount As Double,
                                         SpofStartDate As String,
                                         SpofEndDate As String,
                                         SpofMinQty As Integer,
                                         SpofMaxQty As Integer,
                                         SpofModDate As String,
                                   Optional showCommand As Boolean = False) As Boolean
        Function UpdateSpecialOffersBySp(Spofid As Integer,
                                         SpofName As String,
                                         SpofDesc As String,
                                         SpofType As String,
                                         SpofStartDate As String,
                                         SpofEndDate As String,
                                         SpofMinQty As Integer,
                                         SpofMaxQty As Integer,
                                         SpofModDate As String,
                                   Optional showCommand As Boolean = False) As Spof
    End Interface
End Namespace
