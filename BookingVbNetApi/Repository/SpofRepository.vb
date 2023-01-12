Imports BookingVbNetApi.Model
Imports BookingVbNetApi.Context
Imports System.Data.SqlClient

Namespace Repository
    Public Class SpofRepository
        Implements ISpofRepository

        Private ReadOnly _context As IRepositoryContext

        Public Sub New(context As IRepositoryContext)
            _context = context
        End Sub

        Public Function FindAllSpecialOffers() As List(Of Spof) Implements ISpofRepository.FindAllSpecialOffers
            Dim spofAllList = New List(Of Spof)

            Dim stmt = "SELECT spof_id, spof_name,spof_description, spof_type, spof_discount, spof_start_date, spof_end_date, spof_min_qty, spof_max_qty, spof_modified_date " &
                       "FROM Booking.special_offers"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    Try
                        conn.Open()
                        Dim Reader = cmd.ExecuteReader()
                        While Reader.Read()
                            spofAllList.Add(New Spof() With {
                                    .Spof_id = If(Reader.IsDBNull(0), 0, Reader.GetInt32(0)),
                                    .Spof_name = If(Reader.IsDBNull(1), "", Reader.GetString(1)),
                                    .Spof_description = If(Reader.IsDBNull(2), "", Reader.GetString(2)),
                                    .Spof_type = If(Reader.IsDBNull(3), "", Reader.GetString(3)),
                                    .Spof_discount = If(Reader.IsDBNull(4), 0, Reader.GetDouble(4)),
                                    .Spof_start_date = If(Reader.IsDBNull(5), "", Reader.GetDateTime(5).ToLongDateString),
                                    .Spof_end_date = If(Reader.IsDBNull(6), "", Reader.GetDateTime(6).ToLongDateString),
                                    .Spof_min_qty = If(Reader.IsDBNull(7), 0, Reader.GetInt32(7)),
                                    .Spof_max_qty = If(Reader.IsDBNull(8), 0, Reader.GetInt32(8)),
                                    .Spof_modified_date = If(Reader.IsDBNull(9), "", Reader.GetDateTime(9).ToLongDateString)
                            })
                        End While
                        Reader.Close()
                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
            End Using
            Return spofAllList
        End Function

        Public Function FindSpecialOffersById(id As Integer) As Spof Implements ISpofRepository.FindSpecialOffersById
            Dim spofById As New Spof With {.Spof_id = id}
            Dim stmt = "SELECT spof_name, spof_description, spof_type, spof_discount, spof_start_date, spof_end_date, spof_min_qty, spof_max_qty, spof_modified_date " &
                       "FROM Booking.special_offers " &
                       "WHERE spof_id = @spof_id"

            Using con As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = con, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@spof_id", id)
                    Try
                        con.Open()
                        Dim Reader = cmd.ExecuteReader()
                        If Reader.HasRows Then
                            Reader.Read()
                            spofById.Spof_name = If(Reader.IsDBNull(0), "", Reader.GetString(0))
                            spofById.Spof_description = If(Reader.IsDBNull(1), "", Reader.GetString(1))
                            spofById.Spof_type = If(Reader.IsDBNull(2), "", Reader.GetString(2))
                            spofById.Spof_discount = If(Reader.IsDBNull(3), 0, Reader.GetDouble(3))
                            spofById.Spof_start_date = If(Reader.IsDBNull(4), "", Reader.GetDateTime(4).ToLongDateString)
                            spofById.Spof_end_date = If(Reader.IsDBNull(5), "", Reader.GetDateTime(5).ToLongDateString)
                            spofById.Spof_min_qty = If(Reader.IsDBNull(6), 0, Reader.GetInt32(6))
                            spofById.Spof_max_qty = If(Reader.IsDBNull(7), 0, Reader.GetInt32(7))
                            spofById.Spof_modified_date = If(Reader.IsDBNull(8), "", Reader.GetDateTime(8).ToLongDateString)
                        End If
                        Reader.Close()
                        con.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
            End Using
            Return spofById
        End Function

        Public Function CreateNewSpecialOffers(specialOffers As Spof) As Spof Implements ISpofRepository.CreateNewSpecialOffers
            Dim NewSpof As New Spof()

            Dim stmt = "INSERT INTO Booking.special_offers (spof_name, spof_description, spof_type, spof_discount, spof_start_date, spof_end_date, spof_min_qty, spof_max_qty, spof_modified_date )" &
                       "VALUES (@spofName, @spofDesc, @spofType, @spofDiscount, @spofStartDate, @spofEndDate, @spofMinQty, @spofMaxQty, @spofModDate ) " &
                       "SELECT CAST(scope_identity() AS Integer)"
            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@spofName", specialOffers.Spof_name)
                    cmd.Parameters.AddWithValue("@spofDesc", specialOffers.Spof_description)
                    cmd.Parameters.AddWithValue("@spofType", specialOffers.Spof_type)
                    cmd.Parameters.AddWithValue("@spofDiscount", specialOffers.Spof_discount)
                    cmd.Parameters.AddWithValue("@spofStartDate", specialOffers.Spof_start_date)
                    cmd.Parameters.AddWithValue("@spofEndDate", specialOffers.Spof_end_date)
                    cmd.Parameters.AddWithValue("@spofMinQty", specialOffers.Spof_min_qty)
                    cmd.Parameters.AddWithValue("@spofMaxQty", specialOffers.Spof_max_qty)
                    cmd.Parameters.AddWithValue("@spofModDate", specialOffers.Spof_modified_date)

                    Try
                        conn.Open()
                        Dim SpofId As Integer = cmd.ExecuteScalar()
                        NewSpof = FindSpecialOffersById(SpofId)
                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                End Using
            End Using
            Return NewSpof
        End Function

        Public Function DeleteSpecialOffersByID(id As Integer) As Integer Implements ISpofRepository.DeleteSpecialOffersByID
            Dim rowEffect As Int32 = 0

            Dim stmt As String = "delete from Booking.special_offers where spof_id =@spofid"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@spofid", id)
                    Try
                        conn.Open()
                        rowEffect = cmd.ExecuteNonQuery()
                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
            End Using
            Return rowEffect
        End Function

        Public Function UpdateSpecialOffersById(Spofid As Integer, SpofName As String, SpofDesc As String, SpofType As String, SpofDiscount As Double, SpofStartDate As String, SpofEndDate As String, SpofMinQty As Integer, SpofMaxQty As Integer, SpofModDate As String, Optional showCommand As Boolean = False) As Boolean Implements ISpofRepository.UpdateSpecialOffersById
            Dim updateSpof As New Spof

            Dim stmt = "Update Booking.Special_offers " &
                        "SET " &
                        "spof_name=@spofName, " &
                        "spof_description=@spofDesc, " &
                        "spof_type=@spofType, " &
                        "spof_discount=@spofDiscount, " &
                        "spof_start_date=@spofStartDate, " &
                        "spof_end_date=@spofEndDate, " &
                        "spof_min_qty=@spofMinQty, " &
                        "spof_max_qty=@spofMaxQty, " &
                        "spof_modified_date=@spofModDate " &
                        "WHERE spof_id = @id; "

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@spofName", SpofName)
                    cmd.Parameters.AddWithValue("@spofDesc", SpofDesc)
                    cmd.Parameters.AddWithValue("@spofType", SpofType)
                    cmd.Parameters.AddWithValue("@spofDiscount", SpofDiscount)
                    cmd.Parameters.AddWithValue("@spofStartDate", SpofStartDate)
                    cmd.Parameters.AddWithValue("@spofEndDate", SpofEndDate)
                    cmd.Parameters.AddWithValue("@spofMinQty", SpofMinQty)
                    cmd.Parameters.AddWithValue("@spofMaxQty", SpofMaxQty)
                    cmd.Parameters.AddWithValue("@spofModDate", SpofModDate)
                    cmd.Parameters.AddWithValue("@id", Spofid)

                    If showCommand Then
                        Console.WriteLine("Koneksi Berhasil")
                    End If

                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
            End Using
            Return True
        End Function

        Public Function UpdateSpecialOffersBySp(Spofid As Integer, SpofName As String, SpofDesc As String, SpofType As String, SpofStartDate As String, SpofEndDate As String, SpofMinQty As Integer, SpofMaxQty As Integer, SpofModDate As String, Optional showCommand As Boolean = False) As Spof Implements ISpofRepository.UpdateSpecialOffersBySp
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace