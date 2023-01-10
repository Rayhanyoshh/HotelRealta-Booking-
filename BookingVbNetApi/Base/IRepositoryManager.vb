Imports BookingVbNetApi.Repository
Namespace Base
    Public Interface IRepositoryManager
        ReadOnly Property Booking As IBookingRepository

        ReadOnly Property Borde As IBordeRepository

        ReadOnly Property Boex As IBoexRepoository

        ReadOnly Property Soco As IBookingRepository

        ReadOnly Property Spof As IBookingRepository

        ReadOnly Property Usbr As IBookingRepository




    End Interface
End Namespace