Imports BookingVbNetApi.Model
Imports BookingVbNetApi.Context
Imports System.Data.SqlClient

Namespace Repository
    Public Class BoexRepository
        Implements IBoexRepoository

        Private ReadOnly _context As IRepositoryContext

        Public Sub New(context As IRepositoryContext)
            _context = context
        End Sub

        Public Function FindAllBookingOrderDetailExtra() As List(Of Boex) Implements IBoexRepoository.FindAllBookingOrderDetailExtra
            Dim boexAllList = New List(Of Boex)

            Dim stmt = "SELECT boex_id, boex_price, boex_qty, boex_subtotal, boex_measure_unit, boex_borde_id, boex_prit_id " &
                       "FROM Booking.booking_order_detail_extra"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    Try
                        conn.Open()
                        Dim Reader = cmd.ExecuteReader()

                        While Reader.Read()
                            boexAllList.Add(New Boex() With {
                                .Boex_id = If(Reader.IsDBNull(0), 0, Reader.GetInt32(0)),
                                .Boex_price = If(Reader.IsDBNull(1), 0, Reader.GetDecimal(1)),
                                .Boex_qty = If(Reader.IsDBNull(2), 0, Reader.GetInt16(2)),
                                .Boex_subtotal = If(Reader.IsDBNull(3), 0, Reader.GetDecimal(3)),
                                .Boex_measure_unit = If(Reader.IsDBNull(4), "", Reader.GetString(4)),
                                .Boex_borde_id = If(Reader.IsDBNull(5), 0, Reader.GetInt32(5)),
                                .Boex_prit_id = If(Reader.IsDBNull(6), 0, Reader.GetInt32(6))
                            })
                        End While
                        Reader.Close()
                        conn.Close()

                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
            End Using
            Return boexAllList
        End Function

        Public Function FindBoexByID(id As Integer) As Boex Implements IBoexRepoository.FindBoexByID
            Dim boex As New Boex With {.Boex_id = id}
            Dim stmt = "SELECT boex_price, boex_qty, boex_subtotal, boex_measure_unit, boex_borde_id, boex_prit_id " &
                       "FROM Booking.booking_order_detail_extra " &
                       "WHERE boex_id = @boex_id"

            Using con As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = con, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@boex_id", id)
                    Try
                        con.Open()
                        Dim Reader = cmd.ExecuteReader()
                        If Reader.HasRows Then
                            Reader.Read()
                            boex.Boex_price = If(Reader.IsDBNull(0), 0, Reader.GetDecimal(0))
                            boex.Boex_qty = If(Reader.IsDBNull(1), 0, Reader.GetInt16(1))
                            boex.Boex_subtotal = If(Reader.IsDBNull(2), 0, Reader.GetDecimal(2))
                            boex.Boex_measure_unit = If(Reader.IsDBNull(3), "", Reader.GetString(3))
                            boex.Boex_borde_id = If(Reader.IsDBNull(4), 0, Reader.GetInt32(4))
                            boex.Boex_prit_id = If(Reader.IsDBNull(5), 0, Reader.GetInt32(5))
                        End If
                        Reader.Close()
                        con.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
            End Using
            Return boex
        End Function

        Public Function CreateNewBoex(boex As Boex) As Boex Implements IBoexRepoository.CreateNewBoex
            Dim NewBoex As New Boex()

            Dim stmt = "INSERT INTO Booking.booking_order_detail_extra (boex_price, boex_qty, boex_subtotal, boex_measure_unit, boex_borde_id, boex_prit_id) " &
                       "VALUES (@boexPrice, @boexQty, @boexSubtotal, @boexMeasureUnit, @boexBordeId, @boexPritId) " &
                       "SELECT CAST(scope_identity() AS Integer)"
            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@boexPrice", boex.Boex_price)
                    cmd.Parameters.AddWithValue("@boexQty", boex.Boex_qty)
                    cmd.Parameters.AddWithValue("@boexSubtotal", boex.Boex_subtotal)
                    cmd.Parameters.AddWithValue("@boexMeasureUnit", boex.Boex_measure_unit)
                    cmd.Parameters.AddWithValue("@boexBordeId", boex.Boex_borde_id)
                    cmd.Parameters.AddWithValue("@boexPritId", boex.Boex_prit_id)

                    Try
                        conn.Open()
                        Dim BoexId As Integer = cmd.ExecuteScalar()
                        NewBoex = FindBoexByID(BoexId)
                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                End Using
            End Using
            Return NewBoex
        End Function

        Public Function DeleteBoex(id As Integer) As Integer Implements IBoexRepoository.DeleteBoex
            Dim rowEffect As Int32 = 0

            Dim stmt As String = "delete from Booking.booking_order_detail_extra where boex_id =@id"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@id", id)
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

        Public Function UpdateBoexByID(BoexId As Integer, BoexPrice As Double, BoexQty As Integer, BoexsubTotal As Double, BoexMeasureUnit As String, BoexBordeId As Integer, BoexPritId As Integer, Optional showCommand As Boolean = False) As Boolean Implements IBoexRepoository.UpdateBoexByID
            Dim updateBoex As New Boex

            Dim stmt = "Update Booking.Booking_order_detail_extra " &
                        "SET " &
                        "boex_price=@boexPrice, " &
                        "boex_qty=@boexQty, " &
                        "boex_subtotal=@boexSubtotal, " &
                        "boex_measure_unit=@boexMeasureUnit, " &
                        "boex_borde_id=@boexBordeId, " &
                        "boex_prit_id=@boexPritId " &
                        "WHERE boex_id = @id; "

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}
                    cmd.Parameters.AddWithValue("@boexPrice", BoexPrice)
                    cmd.Parameters.AddWithValue("@boexQty", BoexQty)
                    cmd.Parameters.AddWithValue("@boexSubtotal", BoexsubTotal)
                    cmd.Parameters.AddWithValue("@boexMeasureUnit", BoexMeasureUnit)
                    cmd.Parameters.AddWithValue("@boexBordeId", BoexBordeId)
                    cmd.Parameters.AddWithValue("@boexPritId", BoexPritId)
                    cmd.Parameters.AddWithValue("@id", BoexId)

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
    End Class
End Namespace