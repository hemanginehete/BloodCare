Public Class Form1
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BloodBankBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BloodBankBindingSource.MoveNext()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodbankFinalDataSet.BloodBank' table. You can move, or remove it, as needed.
        Me.BloodBankTableAdapter.Fill(Me.BloodbankFinalDataSet.BloodBank)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count As Integer
        count = BloodBankBindingSource.Count
        TextBox10.Text = "There are + count + Doners"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BloodBankBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BloodBankBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            BloodBankBindingSource.EndEdit()
            BloodBankTableAdapter.Update(BloodbankFinalDataSet.BloodBank)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TextBox10.Text = DataGridView1.Rows.Count()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
