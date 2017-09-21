Module Module1
    Public rs As ADODB.Recordset
    Public rcon As ADODB.Connection
    Public read As OleDb.OleDbDataReader
    Public cmd As OleDb.OleDbCommand
    Public dba As OleDb.OleDbDataAdapter
    Public ds As DataSet
    Public con As OleDb.OleDbConnection

    Public sql As String
    Public Sub main()
        rs = New ADODB.Recordset
        rcon = New ADODB.Connection

        With rs
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            .LockType = ADODB.LockTypeEnum.adLockOptimistic
        End With

        If rcon.State = 1 Then rcon.Close()
        rcon.Open(mpath)

    End Sub

    Public Function mpath() As String
        mpath = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DESKTOP\Documents\Visual Studio 2012\Projects\WindowsApplication1\WindowsApplication1\VS2012.mdb;Persist Security Info=False"
    End Function
    Public Function cmbID()
        If rs.State = 1 Then rs.Close()
        sql = "SELECT ID FROM Tbl_name"
        rs.Open(sql, rcon)

        Form1.cmb1.Items.Clear()
        While Not rs.EOF
            Form1.cmb1.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        End While
    End Function

    Public Function getData(varId As String)
        If rs.State = 1 Then rs.Close()
        sql = "SELECT *FROM Tbl_name WHERE ID = '" + varId + "'"
        rs.Open(sql, rcon)

        If Not rs.EOF Then
            Form1.txt1.Text = rs.Fields(0).Value
            Form1.txt2.Text = rs.Fields(1).Value
            Form1.txt3.Text = rs.Fields(2).Value
        End If
    End Function

    Public Function mysave(varid As String, varName As String, varLast As String)
        If rs.State = 1 Then rs.Close()
        sql = ("SELECT *FROM Tbl_name WHERE ID = '" + varid + "'")
        rs.Open(sql, rcon)
        With rs
            .AddNew()
            .Fields(0).Value = varid
            .Fields(1).Value = varName
            .Fields(2).Value = varLast
            .Update()
        End With
    End Function

    Public Function myupdate(varid As String, varName As String, varLast As String)
        If rs.State = 1 Then rs.Close()
        sql = ("SELECT *FROM Tbl_name WHERE ID = '" + varid + "'")
        rs.Open(sql, rcon)
        With rs
            .Update()
            .Fields(0).Value = varid
            .Fields(1).Value = varName
            .Fields(2).Value = varLast
            .Update()
        End With
    End Function

    Public Function myDelete(varID As String)
        If rs.State = 1 Then rs.Close()
        sql = "DELETE *FROM Tbl_name WHERE ID = '" + varID + "'"
        rs.Open(sql, rcon)
        MsgBox("Data was successfully deleted.", MsgBoxStyle.Information, "DELETE")
    End Function

End Module