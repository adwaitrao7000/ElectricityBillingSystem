﻿Imports System.Data.OleDb
Public Class AddCustomer
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\proj\ElectricityBillingSystem\ElectricityBillingSystem\ElectricityBillingDB.accdb")
    Dim ds As New DataSet
    Dim cmd As New OleDbCommand("select * from Customer_Info", conn)
    Dim da As New OleDbDataAdapter
    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "Customer_Info")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("TextField Cannot Be Empty", MsgBoxStyle.Critical)
        Else
            cmd = New OleDbCommand("insert into Customer_Info(customerName,meterNumber,City,Address,State,Email) values ('" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox3.Text & "', '" & TextBox6.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Inserted Succesfully")
        End If
    End Sub
End Class