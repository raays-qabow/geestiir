Public Class Form1
    Dim cat As String

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then

            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y

        End If

    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = MouseButtons.Left Then

            IsFormBeingDragged = False

        End If

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove

        If IsFormBeingDragged Then

            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)

            temp.Y = Me.Location.Y + (e.Y - MouseDownY)

            Me.Location = temp

            temp = Nothing

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VS2012DataSet.Tbl_name' table. You can move, or remove it, as needed.
        Me.Tbl_nameTableAdapter.Fill(Me.VS2012DataSet.Tbl_name)

        Call main()
        cmbID()
    End Sub

    Sub clear()
        Dim control
        For Each control In Me.Controls
            If TypeOf control Is TextBox Or TypeOf control Is ComboBox Then
                control.text = vbNullString
            End If
        Next control
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clear()
        DataGridView1.DataSource = ""
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        'TODO this line of code get the connection from a selected datasource
        Dim con As OleDb.OleDbConnection
        'TODO this line of code refers to where an actual connection string from a datasource will be inputted
        con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DESKTOP\Documents\Visual Studio 2012\Projects\WindowsApplication1\WindowsApplication1\VS2012.mdb;Persist Security Info=False")
        'TODO this line of code open the connection from a datasource
        con.Open()

        Dim dba As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT *FROM Tbl_name WHERE " + ComboBox1.Text + " LIKE '" + txtsearch.Text + "%'", con)
        Dim ds As DataSet = New DataSet
        dba.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call main()
        myDelete(txt1.Text)
        cmbID()
        clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO this line of code get the connection from a selected datasource
        Dim con As OleDb.OleDbConnection
        'TODO this line of code refers to where an actual connection string from a datasource will be inputted
        con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DESKTOP\Documents\Visual Studio 2012\Projects\WindowsApplication1\WindowsApplication1\VS2012.mdb;Persist Security Info=False")
        'TODO this line of code open the connection from a datasource
        con.Open()

        Dim dba As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("SELECT *FROM Tbl_name", con)
        Dim ds As DataSet = New DataSet
        dba.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call main()
        mysave(txt1.Text, txt2.Text, txt3.Text)
        cmbID()
        clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call main()
        myupdate(txt1.Text, txt2.Text, txt3.Text)
        cmbID()
        clear()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        Call main()
        getData(cmb1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        If ComboBox1.Text = "ID" Then
            cat = "ID"
        End If
        If ComboBox1.Text = "Firstname" Then
            cat = "firstname"
        End If
        If ComboBox1.Text = "Lastname" Then
            cat = "lastname"
        End If
    End Sub

End Class
