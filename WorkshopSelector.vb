Public Class FormSelector
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstPic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPic.SelectedIndexChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstPic.SelectedIndex = -1
        lstLocation.SelectedIndex = -1
        lstCosts.Items.Clear()
        lblMess.Text = String.Empty
    End Sub

    Private Sub lstLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLocation.SelectedIndexChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim intTotal As Integer
        Dim intWorkshop As Integer
        Dim intLodging As Integer
        Dim intLocation As Integer
        intLodging = 1

        Select Case CInt(lstPic.SelectedIndex)
            Case 0
                intWorkshop = 595
                intLodging *= 3
            Case 1
                intWorkshop = 695
                intLodging *= 3
            Case 2
                intWorkshop = 995
                intLodging *= 3
            Case 3
                intWorkshop = 1295
                intLodging *= 5
            Case 4
                intWorkshop = 395
                intLodging *= 1
        End Select

        Select Case CInt(lstLocation.SelectedIndex)
            Case 0
                intLocation = 95
            Case 1
                intLocation = 125

            Case 2
                intLocation = 110

            Case 3
                intLocation = 100

            Case 4
                intLocation = 92

            Case 5
                intLocation = 90
        End Select
        intTotal = intWorkshop + intLocation * intLodging

        lstCosts.Items.Add(intTotal)
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim totalCost As Integer

        For Each str As String In lstCosts.Items
            totalCost = totalCost + CInt(str)
        Next
        lblMess.Text = totalCost.ToString("c")
    End Sub
End Class
