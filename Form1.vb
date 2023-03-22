Public Class Form1
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBdatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBdatabaseDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.VBdatabaseDataSet.Employees)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeesBindingSource.AddNew()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            EmployeesBindingSource.EndEdit()
            EmployeesTableAdapter.Update(VBdatabaseDataSet.Employees)
            MessageBox.Show("Data saved Successfully!")
        Catch ex As Exception
            MessageBox.Show("Error occurred while saving data!!")

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EmployeesBindingSource.RemoveCurrent()

    End Sub
End Class
