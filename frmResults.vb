Imports System.IO

Public Class frmResults
    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Dim startDate As Date = dtpStart.Value
        Dim endDate As Date = dtpEnd.Value
        Dim adapter As New BookCollectionDataSetTableAdapters.salesTableAdapter
        Dim sw As streamwriter = New streamwriter("Report.txt")
        sw.WriteLine("Order Number, Title ID, Quantity, Order Date")
        Dim dt As New BookCollectionDataSet.salesDataTable

        adapter.Fill(dt)

        For Each row As DataRow In dt.Rows
            If row.Item(2) >= startDate And row.Item(2) <= endDate Then
                sw.WriteLine(row.Item(1) & "," & row.Item(5) & "," & row.Item(3) & "," & row.Item(2))
            End If
        Next

        sw.Close()
    End Sub



End Class