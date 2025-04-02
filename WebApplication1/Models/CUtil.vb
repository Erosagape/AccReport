Imports System.Data.SqlClient
Imports System.Data
Public Class CUtil
    Private ReadOnly cn As New SqlConnection
    Private ReadOnly isConn As Boolean = False
    Private ReadOnly conn As String
    Private msg As String
    Public Function Message() As String
        Return msg
    End Function
    Public Sub New()
        Me.New(My.Settings.WebConnect)
    End Sub
    Public Sub New(str As String)
        conn = str
        cn = New SqlConnection(conn)
        Try
            cn.Open()
            cn.Close()
            isConn = True
        Catch ex As Exception
            msg = ex.Message
        End Try
    End Sub
    Public Function IsConnect() As Boolean
        Return isConn
    End Function
    Public Function GetDouble(o As Object) As Double
        Try
            Return Convert.ToDouble(o)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function IsDouble(o As Object) As Boolean
        Try
            Return Convert.ToDouble(o)
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function ExecuteSQL(str As String) As String
        msg = "OK"
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Using cm = New SqlCommand(str, cn)
                cm.CommandType = CommandType.Text
                cm.CommandTimeout = 1800
                cm.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            msg = ex.Message
        End Try
        cn.Close()
        Return msg
    End Function
    Public Function GetDataFromSQL(str As String) As DataTable
        msg = ""
        Dim dt As New DataTable
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Using cm = New SqlCommand(str, cn)
                cm.CommandType = CommandType.Text
                cm.CommandTimeout = 1800
                Using da As New SqlDataAdapter(cm)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            msg = ex.Message
        End Try
        cn.Close()
        Return dt
    End Function
End Class
