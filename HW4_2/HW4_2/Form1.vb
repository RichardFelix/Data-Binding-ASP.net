Imports System.Data.SqlClient


Public Class Form1

    Dim mydt As DataTable = New System.Data.DataTable
    Dim myconn As SqlConnection = New SqlConnection
    Dim connString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\richard\documents\visual studio 2013\Projects\HW4_2\HW4_2\VeryBoards.mdf;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProductTableAdapter.Fill(Me.VeryBoardsDataSet.Product)

        myconn.ConnectionString = connString
        myconn.Open()

        Dim myadapter As New SqlDataAdapter
        Dim mycmd As New SqlCommand

        myadapter.SelectCommand = mycmd
        mycmd.CommandText = "Select * from Product"
        mycmd.Connection = myconn

        mydt.Clear()
        myadapter.Fill(mydt)

        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = mydt 'Binding

        For i As Integer = 0 To DataGridView1.RowCount - 1  'get all current records
            DataGridView1.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(1).Value + " " + DataGridView1.Rows(i).Cells(2).Value
        Next

        myconn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        myconn.ConnectionString = connString
        myconn.Open()

        Dim updatecmd As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        myadapter.SelectCommand = updatecmd

        updatecmd.CommandText = "Update Product Set Description = @Descript, MfgID = @Mfg, Unit = @Unit_temp,  WHERE ProductID = @pID" 'Cost = @Cost_temp, LastOrderDate = @LastOrderDate_temp,LastOrderQuanity = @LastOrderQuanity_temp
        updatecmd.Parameters.Add("@pID", SqlDbType.NVarChar, 4, "ProductID")
        updatecmd.Parameters.Add("@Descript", SqlDbType.NVarChar, 20, "Description")
        updatecmd.Parameters.Add("@Mfg", SqlDbType.NVarChar, 3, "MfgID")
        updatecmd.Parameters.Add("@Unit_temp", SqlDbType.NVarChar, 10, "Unit")
        ' updatecmd.Parameters.Add("@Cost_temp", SqlDbType.Money, 10, "Cost")
        ' updatecmd.Parameters.Add("@LastOrderDate_temp", SqlDbType.DateTime, "LastOrderDate")
        ' updatecmd.Parameters.Add("@LastOrderQuanity_temp", SqlDbType.SmallInt, "LastOrderQuanity")

        Dim deletecmd As New SqlCommand
        myadapter.DeleteCommand = deletecmd
        deletecmd.Connection = myconn
        deletecmd.CommandText = "DELETE Product WHERE ProductID = @pID "
        deletecmd.Parameters.Add("@pID", SqlDbType.NVarChar, 4, "ProductID")

        Dim insertcmd As New SqlCommand
        myadapter.InsertCommand = insertcmd
        insertcmd.Connection = myconn
        insertcmd.CommandText = "Insert Into Product (ProductID,Description,MfgID,Unit) Values (@pID, @p_Desc, @p_MfID, @p_Unit)"
        insertcmd.Parameters.Add("@pID", SqlDbType.NVarChar, 4, "ProductID")
        insertcmd.Parameters.Add("@p_Desc", SqlDbType.NVarChar, 20, "Description")
        insertcmd.Parameters.Add("@p_MfID", SqlDbType.NVarChar, 3, "MfgID")
        insertcmd.Parameters.Add("@p_Unit", SqlDbType.NVarChar, 10, "Unit")
        ' insertcmd.Parameters.Add("@Cost_temp", SqlDbType.Money, 10, "Cost")
        ' insertcmd.Parameters.Add("@LastOrderDate_temp", SqlDbType.DateTime, "LastOrderDate")
        ' insertcmd.Parameters.Add("@LastOrderQuanity_temp", SqlDbType.SmallInt, "LastOrderQuanity")

        myadapter.ContinueUpdateOnError = True
        myadapter.Update(mydt)

        myconn.Close()

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        mydt.RejectChanges()
    End Sub
End Class
