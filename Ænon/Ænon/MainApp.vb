Imports System.Net
Imports System.IO

Public Class MainApp
    Private Function getHTML(ByVal Adress As String) As String
        Dim rt As String = ""

        Dim wRequest As WebRequest
        Dim wResponse As WebResponse

        Dim SR As StreamReader

        wRequest = WebRequest.Create(Adress)
        wResponse = wRequest.GetResponse

        SR = New StreamReader(wResponse.GetResponseStream)

        rt = SR.ReadToEnd
        SR.Close()

        Return rt

    End Function




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dev.SelectedIndexChanged
        Dim comp As String = dev.SelectedItem
        Select Case comp
            Case "iPhone"
                model.Items.Clear()
                vers.Items.Clear()
                model.Items.Add("iPhone 2G")
                model.Items.Add("iPhone 3G")
                model.Items.Add("iPhone 3GS")
                model.Items.Add("iPhone 4 (3.1)")
                model.Items.Add("iPhone 4 (3.2)")
                model.Items.Add("iPhone 4 (3.3)")
                model.Items.Add("iPhone 4S")
                model.Items.Add("iPhone 5 (5.1)")
                model.Items.Add("iPhone 5 (5.2)")
                model.Items.Add("iPhone 5C (5.3)")
                model.Items.Add("iPhone 5C (5.4)")
                model.Items.Add("iPhone 5S (6.1)")
                model.Items.Add("iPhone 5S (6.2)")
                model.Items.Add("iPhone 6")
                model.Items.Add("iPhone 6 plus")
                model.Items.Add("iPhone 6S")
                model.Items.Add("iPhone 6S plus")
                model.Items.Add("iPhone 7")
                model.Items.Add("iPhone 7 plus")
                model.Items.Add("iPhone 8")
                model.Items.Add("iPhone 8 plus")
                model.Items.Add("iPhone X")
            Case "iPad"
                model.Items.Clear()
                vers.Items.Clear()
                model.Items.Add("iPad 1")
                model.Items.Add("iPad 2")
                model.Items.Add("iPad 3")
                model.Items.Add("iPad 4")
                model.Items.Add("iPad 5")
                model.Items.Add("iPad Pro 12.9")
                model.Items.Add("iPad Pro 9.7")
                model.Items.Add("iPad Pro 12.9 G2")
                model.Items.Add("iPad Pro 10.5 G2")
                model.Items.Add("iPad Air 1")
                model.Items.Add("iPad Air 2")
            Case "iPad Mini"
                model.Items.Clear()
                vers.Items.Clear()
                model.Items.Add("iPad Mini 1")
                model.Items.Add("iPad Mini 2")
                model.Items.Add("iPad Mini 3")
                model.Items.Add("iPad Mini 4")
            Case "iPod touch"
                model.Items.Clear()
                vers.Items.Clear()
                model.Items.Add("iPof Touch 1st Gen")
                model.Items.Add("iPof Touch 2nd Gen")
                model.Items.Add("iPof Touch 3rd Gen")
                model.Items.Add("iPof Touch 4th Gen")
                model.Items.Add("iPof Touch 5th Gen")
                model.Items.Add("iPof Touch 6th Gen")

        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles RFkey.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles model.SelectedIndexChanged
        Dim comp As String = model.SelectedItem
        Select Case comp
            Case "iPhone 2G"
                vers.Items.Clear()
                vers.Items.Add("iOS 1.0")
                vers.Items.Add("iOS 1.0.1")
                vers.Items.Add("iOS 1.0.2")
                vers.Items.Add("iOS 1.1.1")
                vers.Items.Add("iOS 1.1.2")
                vers.Items.Add("iOS 1.1.3")
                vers.Items.Add("iOS 1.1.4")
                vers.Items.Add("iOS 2.0")
                vers.Items.Add("iOS 2.0.1")
                vers.Items.Add("iOS 2.0.2")
                vers.Items.Add("iOS 2.1")
                vers.Items.Add("iOS 2.2")
                vers.Items.Add("iOS 2.2.1")
                vers.Items.Add("iOS 3.0")
                vers.Items.Add("iOS 3.0.1")
                vers.Items.Add("iOS 3.1")
                vers.Items.Add("iOS 3.1.2")
                vers.Items.Add("iOS 3.1.3")
            Case "iPhone 3G"
                vers.Items.Clear()
                vers.Items.Add("iOS 2.0")
                vers.Items.Add("iOS 2.0.1")
                vers.Items.Add("iOS 2.0.2")
                vers.Items.Add("iOS 2.1")
                vers.Items.Add("iOS 2.2")
                vers.Items.Add("iOS 2.2.1")
                vers.Items.Add("iOS 3.0")
                vers.Items.Add("iOS 3.0.1")
                vers.Items.Add("iOS 3.1")
                vers.Items.Add("iOS 3.1.2")
                vers.Items.Add("iOS 3.1.3")
                vers.Items.Add("iOS 4.0")
                vers.Items.Add("iOS 4.0.1")
                vers.Items.Add("iOS 4.0.2")
                vers.Items.Add("iOS 4.1")
                vers.Items.Add("iOS 4.2.1")
            Case "iPhone 3GS"
                vers.Items.Clear()
                vers.Items.Add("iOS 3.0")
                vers.Items.Add("iOS 3.0.1")
                vers.Items.Add("iOS 3.1")
                vers.Items.Add("iOS 3.1.2")
                vers.Items.Add("iOS 3.1.3")
                vers.Items.Add("iOS 4.0")
                vers.Items.Add("iOS 4.0.1")
                vers.Items.Add("iOS 4.0.2")
                vers.Items.Add("iOS 4.1")
                vers.Items.Add("iOS 4.2.1")
                vers.Items.Add("iOS 4.3")
                vers.Items.Add("iOS 4.3.1")
                vers.Items.Add("iOS 4.3.2")
                vers.Items.Add("iOS 4.3.3")
                vers.Items.Add("iOS 4.3.4")
                vers.Items.Add("iOS 4.3.5")
                vers.Items.Add("iOS 5.0")
                vers.Items.Add("iOS 5.0.1")
                vers.Items.Add("iOS 5.1")
                vers.Items.Add("iOS 5.1.1")
                vers.Items.Add("iOS 6.0")
                vers.Items.Add("iOS 6.0.1")
                vers.Items.Add("iOS 6.1")
                vers.Items.Add("iOS 6.1.2")
                vers.Items.Add("iOS 6.1.3")
                vers.Items.Add("iOS 6.1.6")
            Case "iPhone 4 (3.1)"
                vers.Items.Clear()
                vers.Items.Add("iOS 4.0")
                vers.Items.Add("iOS 4.0.1")
                vers.Items.Add("iOS 4.0.2")
                vers.Items.Add("iOS 4.1")
                vers.Items.Add("iOS 4.2")
                vers.Items.Add("iOS 4.2.1")
                vers.Items.Add("iOS 4.3")
                vers.Items.Add("iOS 4.3.1")
                vers.Items.Add("iOS 4.3.2")
                vers.Items.Add("iOS 4.3.3")
                vers.Items.Add("iOS 4.3.4")
                vers.Items.Add("iOS 4.3.5")
                vers.Items.Add("iOS 5.0")
                vers.Items.Add("iOS 5.0.1")
                vers.Items.Add("iOS 5.1")
                vers.Items.Add("iOS 5.1.1")
                vers.Items.Add("iOS 6.0")
                vers.Items.Add("iOS 6.0.1")
                vers.Items.Add("iOS 6.1")
                vers.Items.Add("iOS 6.1.2")
                vers.Items.Add("iOS 6.1.3")
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.1")
                vers.Items.Add("iOS 7.1.2")
            Case "iPhone 4 (3.2)"
                vers.Items.Clear()
                vers.Items.Add("iOS 6.0")
                vers.Items.Add("iOS 6.0.1")
                vers.Items.Add("iOS 6.1")
                vers.Items.Add("iOS 6.1.2")
                vers.Items.Add("iOS 6.1.3")
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.1")
                vers.Items.Add("iOS 7.1.2")
            Case "iPhone 4 (3.3)"
                vers.Items.Clear()
                vers.Items.Add("iOS 4.0")
                vers.Items.Add("iOS 4.0.1")
                vers.Items.Add("iOS 4.0.2")
                vers.Items.Add("iOS 4.1")
                vers.Items.Add("iOS 4.2")
                vers.Items.Add("iOS 4.2.1")
                vers.Items.Add("iOS 4.3")
                vers.Items.Add("iOS 4.3.1")
                vers.Items.Add("iOS 4.3.2")
                vers.Items.Add("iOS 4.3.3")
                vers.Items.Add("iOS 4.3.4")
                vers.Items.Add("iOS 4.3.5")
                vers.Items.Add("iOS 5.0")
                vers.Items.Add("iOS 5.0.1")
                vers.Items.Add("iOS 5.1")
                vers.Items.Add("iOS 5.1.1")
                vers.Items.Add("iOS 6.0")
                vers.Items.Add("iOS 6.0.1")
                vers.Items.Add("iOS 6.1")
                vers.Items.Add("iOS 6.1.2")
                vers.Items.Add("iOS 6.1.3")
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.1")
                vers.Items.Add("iOS 7.1.2")
            Case "iPhone 4S"
                vers.Items.Clear()
                vers.Items.Add("iOS 5.0")
                vers.Items.Add("iOS 5.0.1 (nov)")
                vers.Items.Add("iOS 5.0.1 (dec)")
                vers.Items.Add("iOS 5.1")
                vers.Items.Add("iOS 5.1.1")
                vers.Items.Add("iOS 6.0")
                vers.Items.Add("iOS 6.0.1")
                vers.Items.Add("iOS 6.1")
                vers.Items.Add("iOS 6.1.1")
                vers.Items.Add("iOS 6.1.2")
                vers.Items.Add("iOS 6.1.3")
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.1")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.1")
                vers.Items.Add("iOS 7.1.2")
                vers.Items.Add("iOS 8.0")
                vers.Items.Add("iOS 8.0.1")
                vers.Items.Add("iOS 8.0.2")
                vers.Items.Add("iOS 8.1")
                vers.Items.Add("iOS 8.1.1")
                vers.Items.Add("iOS 8.1.2")
                vers.Items.Add("iOS 8.1.3")
                vers.Items.Add("iOS 8.2")
                vers.Items.Add("iOS 8.3")
                vers.Items.Add("iOS 8.4")
                vers.Items.Add("iOS 8.4.1")
                vers.Items.Add("iOS 9.0")
                vers.Items.Add("iOS 9.0.1")
                vers.Items.Add("iOS 9.0.2")
                vers.Items.Add("iOS 9.1")
                vers.Items.Add("iOS 9.2")
                vers.Items.Add("iOS 9.2.1")
                vers.Items.Add("iOS 9.3")
                vers.Items.Add("iOS 9.3.1")
                vers.Items.Add("iOS 9.3.2")
                vers.Items.Add("iOS 9.3.3")
                vers.Items.Add("iOS 9.3.4")
                vers.Items.Add("iOS 9.3.5")
            Case "iPhone 5 (5.1)"
                vers.Items.Clear()
                vers.Items.Add("iOS 6.0")
                vers.Items.Add("iOS 6.0.1")
                vers.Items.Add("iOS 6.0.2")
                vers.Items.Add("iOS 6.1")
                vers.Items.Add("iOS 6.1.2")
                vers.Items.Add("iOS 6.1.3")
                vers.Items.Add("iOS 6.1.4")
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.2")
                vers.Items.Add("iOS 8.0")
                vers.Items.Add("iOS 8.0.1")
                vers.Items.Add("iOS 8.0.2")
                vers.Items.Add("iOS 8.1")
                vers.Items.Add("iOS 8.1.2")
                vers.Items.Add("iOS 8.1.3")
                vers.Items.Add("iOS 8.2")
                vers.Items.Add("iOS 8.3")
                vers.Items.Add("iOS 8.4")
                vers.Items.Add("iOS 8.4.1")
                vers.Items.Add("iOS 9.0")
                vers.Items.Add("iOS 9.0.1")
                vers.Items.Add("iOS 9.0.2")
                vers.Items.Add("iOS 9.1")
                vers.Items.Add("iOS 9.2")
                vers.Items.Add("iOS 9.2.1")
                vers.Items.Add("iOS 9.3")
                vers.Items.Add("iOS 9.3.1")
                vers.Items.Add("iOS 9.3.2")
                vers.Items.Add("iOS 9.3.3")
                vers.Items.Add("iOS 9.3.4")
                vers.Items.Add("iOS 9.3.5")
                vers.Items.Add("iOS 10.0.1")
                vers.Items.Add("iOS 10.0.2")
                vers.Items.Add("iOS 10.1")
                vers.Items.Add("iOS 10.1.1")
                vers.Items.Add("iOS 10.2")
                vers.Items.Add("iOS 10.2.1")
                vers.Items.Add("iOS 10.3")
                vers.Items.Add("iOS 10.3.1")
                vers.Items.Add("iOS 10.3.2")
                vers.Items.Add("iOS 10.3.3")
            Case "iPhone 5 (5.2)"
                vers.Items.Clear()
                vers.Items.Add("iOS 6.0")
                vers.Items.Add("iOS 6.0.1")
                vers.Items.Add("iOS 6.0.2")
                vers.Items.Add("iOS 6.1")
                vers.Items.Add("iOS 6.1.2")
                vers.Items.Add("iOS 6.1.3")
                vers.Items.Add("iOS 6.1.4")
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.2")
                vers.Items.Add("iOS 8.0")
                vers.Items.Add("iOS 8.0.1")
                vers.Items.Add("iOS 8.0.2")
                vers.Items.Add("iOS 8.1")
                vers.Items.Add("iOS 8.1.2")
                vers.Items.Add("iOS 8.1.3")
                vers.Items.Add("iOS 8.2")
                vers.Items.Add("iOS 8.3")
                vers.Items.Add("iOS 8.4")
                vers.Items.Add("iOS 8.4.1")
                vers.Items.Add("iOS 9.0")
                vers.Items.Add("iOS 9.0.1")
                vers.Items.Add("iOS 9.0.2")
                vers.Items.Add("iOS 9.1")
                vers.Items.Add("iOS 9.2")
                vers.Items.Add("iOS 9.2.1")
                vers.Items.Add("iOS 9.3")
                vers.Items.Add("iOS 9.3.1")
                vers.Items.Add("iOS 9.3.2")
                vers.Items.Add("iOS 9.3.3")
                vers.Items.Add("iOS 9.3.4")
                vers.Items.Add("iOS 9.3.5")
                vers.Items.Add("iOS 10.0.1")
                vers.Items.Add("iOS 10.0.2")
                vers.Items.Add("iOS 10.1")
                vers.Items.Add("iOS 10.1.1")
                vers.Items.Add("iOS 10.2")
                vers.Items.Add("iOS 10.2.1")
                vers.Items.Add("iOS 10.3")
                vers.Items.Add("iOS 10.3.1")
                vers.Items.Add("iOS 10.3.2")
                vers.Items.Add("iOS 10.3.3")
            Case "iPhone 5 (5.3)"
                vers.Items.Clear()
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.1")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.2")
                vers.Items.Add("iOS 8.0")
                vers.Items.Add("iOS 8.0.1")
                vers.Items.Add("iOS 8.0.2")
                vers.Items.Add("iOS 8.1")
                vers.Items.Add("iOS 8.1.2")
                vers.Items.Add("iOS 8.1.3")
                vers.Items.Add("iOS 8.2")
                vers.Items.Add("iOS 8.3")
                vers.Items.Add("iOS 8.4")
                vers.Items.Add("iOS 8.4.1")
                vers.Items.Add("iOS 9.0")
                vers.Items.Add("iOS 9.0.1")
                vers.Items.Add("iOS 9.0.2")
                vers.Items.Add("iOS 9.1")
                vers.Items.Add("iOS 9.2")
                vers.Items.Add("iOS 9.2.1")
                vers.Items.Add("iOS 9.3")
                vers.Items.Add("iOS 9.3.1")
                vers.Items.Add("iOS 9.3.2")
                vers.Items.Add("iOS 9.3.3")
                vers.Items.Add("iOS 9.3.4")
                vers.Items.Add("iOS 9.3.5")
                vers.Items.Add("iOS 10.0.1")
                vers.Items.Add("iOS 10.0.2")
                vers.Items.Add("iOS 10.1")
                vers.Items.Add("iOS 10.1.1")
                vers.Items.Add("iOS 10.2")
                vers.Items.Add("iOS 10.2.1")
                vers.Items.Add("iOS 10.3")
                vers.Items.Add("iOS 10.3.1")
                vers.Items.Add("iOS 10.3.2")
                vers.Items.Add("iOS 10.3.3")
            Case "iPhone 5C (5.4)"
                vers.Items.Clear()
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.1")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.2")
                vers.Items.Add("iOS 8.0")
                vers.Items.Add("iOS 8.0.1")
                vers.Items.Add("iOS 8.0.2")
                vers.Items.Add("iOS 8.1")
                vers.Items.Add("iOS 8.1.2")
                vers.Items.Add("iOS 8.1.3")
                vers.Items.Add("iOS 8.2")
                vers.Items.Add("iOS 8.3")
                vers.Items.Add("iOS 8.4")
                vers.Items.Add("iOS 8.4.1")
                vers.Items.Add("iOS 9.0")
                vers.Items.Add("iOS 9.0.1")
                vers.Items.Add("iOS 9.0.2")
                vers.Items.Add("iOS 9.1")
                vers.Items.Add("iOS 9.2")
                vers.Items.Add("iOS 9.2.1")
                vers.Items.Add("iOS 9.3")
                vers.Items.Add("iOS 9.3.1")
                vers.Items.Add("iOS 9.3.2")
                vers.Items.Add("iOS 9.3.3")
                vers.Items.Add("iOS 9.3.4")
                vers.Items.Add("iOS 9.3.5")
                vers.Items.Add("iOS 10.0.1")
                vers.Items.Add("iOS 10.0.2")
                vers.Items.Add("iOS 10.1")
                vers.Items.Add("iOS 10.1.1")
                vers.Items.Add("iOS 10.2")
                vers.Items.Add("iOS 10.2.1")
                vers.Items.Add("iOS 10.3")
                vers.Items.Add("iOS 10.3.1")
                vers.Items.Add("iOS 10.3.2")
                vers.Items.Add("iOS 10.3.3")
            Case "iPhone 5S (6.2)"
                vers.Items.Clear()
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.1")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.2")
                vers.Items.Add("iOS 8.0")
                vers.Items.Add("iOS 8.0.1")
                vers.Items.Add("iOS 8.0.2")
                vers.Items.Add("iOS 8.1")
                vers.Items.Add("iOS 8.1.2")
                vers.Items.Add("iOS 8.1.3")
                vers.Items.Add("iOS 8.2")
                vers.Items.Add("iOS 8.3")
                vers.Items.Add("iOS 8.4")
                vers.Items.Add("iOS 8.4.1")
                vers.Items.Add("iOS 9.0")
                vers.Items.Add("iOS 9.0.1")
                vers.Items.Add("iOS 9.0.2")
                vers.Items.Add("iOS 9.1")
                vers.Items.Add("iOS 9.2")
                vers.Items.Add("iOS 9.2.1")
                vers.Items.Add("iOS 9.3")
                vers.Items.Add("iOS 9.3.1")
                vers.Items.Add("iOS 9.3.2")
                vers.Items.Add("iOS 9.3.3")
                vers.Items.Add("iOS 9.3.4")
                vers.Items.Add("iOS 9.3.5")
                vers.Items.Add("iOS 10.0.1")
                vers.Items.Add("iOS 10.0.2")
                vers.Items.Add("iOS 10.1")
                vers.Items.Add("iOS 10.1.1")
                vers.Items.Add("iOS 10.2")
                vers.Items.Add("iOS 10.2.1")
                vers.Items.Add("iOS 10.3")
                vers.Items.Add("iOS 10.3.1")
                vers.Items.Add("iOS 10.3.2")
                vers.Items.Add("iOS 10.3.3")
                vers.Items.Add("iOS 11.0")
                vers.Items.Add("iOS 11.0.1")
                vers.Items.Add("iOS 11.0.2")
                vers.Items.Add("iOS 11.0.3")
                vers.Items.Add("iOS 11.1")
                vers.Items.Add("iOS 11.1.1")
                vers.Items.Add("iOS 11.1.2")
                vers.Items.Add("iOS 11.2")
            Case "iPhone 5S (6.1)"
                vers.Items.Clear()
                vers.Items.Add("iOS 7.0")
                vers.Items.Add("iOS 7.0.1")
                vers.Items.Add("iOS 7.0.2")
                vers.Items.Add("iOS 7.0.3")
                vers.Items.Add("iOS 7.0.4")
                vers.Items.Add("iOS 7.0.6")
                vers.Items.Add("iOS 7.1")
                vers.Items.Add("iOS 7.1.2")
                vers.Items.Add("iOS 8.0")
                vers.Items.Add("iOS 8.0.1")
                vers.Items.Add("iOS 8.0.2")
                vers.Items.Add("iOS 8.1")
                vers.Items.Add("iOS 8.1.2")
                vers.Items.Add("iOS 8.1.3")
                vers.Items.Add("iOS 8.2")
                vers.Items.Add("iOS 8.3")
                vers.Items.Add("iOS 8.4")
                vers.Items.Add("iOS 8.4.1")
                vers.Items.Add("iOS 9.0")
                vers.Items.Add("iOS 9.0.1")
                vers.Items.Add("iOS 9.0.2")
                vers.Items.Add("iOS 9.1")
                vers.Items.Add("iOS 9.2")
                vers.Items.Add("iOS 9.2.1")
                vers.Items.Add("iOS 9.3")
                vers.Items.Add("iOS 9.3.1")
                vers.Items.Add("iOS 9.3.2")
                vers.Items.Add("iOS 9.3.3")
                vers.Items.Add("iOS 9.3.4")
                vers.Items.Add("iOS 9.3.5")
                vers.Items.Add("iOS 10.0.1")
                vers.Items.Add("iOS 10.0.2")
                vers.Items.Add("iOS 10.1")
                vers.Items.Add("iOS 10.1.1")
                vers.Items.Add("iOS 10.2")
                vers.Items.Add("iOS 10.2.1")
                vers.Items.Add("iOS 10.3")
                vers.Items.Add("iOS 10.3.1")
                vers.Items.Add("iOS 10.3.2")
                vers.Items.Add("iOS 10.3.3")
                vers.Items.Add("iOS 11.0")
                vers.Items.Add("iOS 11.0.1")
                vers.Items.Add("iOS 11.0.2")
                vers.Items.Add("iOS 11.0.3")
                vers.Items.Add("iOS 11.1")
                vers.Items.Add("iOS 11.1.1")
                vers.Items.Add("iOS 11.1.2")
                vers.Items.Add("iOS 11.2")
            Case "iPhone 6"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone 6 plus"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone 6S"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone 6S plus"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone 7"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone 7 plus"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone 8"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone 8 plus"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPhone X"
                vers.Items.Clear()
                vers.Items.Add("No keys out!")
            Case "iPad 1"
                vers.Items.Clear()
                vers.Items.Add("iOS 3.2")
                vers.Items.Add("iOS 3.2.1")
                vers.Items.Add("iOS 3.2.2")
                vers.Items.Add("iOS 4.2.1")
                vers.Items.Add("iOS 4.3")
                vers.Items.Add("iOS 4.3.1")
                vers.Items.Add("iOS 4.3.2")
                vers.Items.Add("iOS 4.3.3")
                vers.Items.Add("iOS 4.3.4")
                vers.Items.Add("iOS 4.3.5")
                vers.Items.Add("iOS 5.0")
                vers.Items.Add("iOS 5.0.1")
                vers.Items.Add("iOS 5.1")
                vers.Items.Add("iOS 5.1.1")
            Case "iPad 2.5"
                vers.Items.Clear()
                vers.Items.Add("coming soon")
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vers.SelectedIndexChanged

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(dev.Text)) Then
            MessageBox.Show("No device was selected!")
        ElseIf (String.IsNullOrEmpty(model.Text)) Then
            MessageBox.Show("No model selected!")
        ElseIf (String.IsNullOrEmpty(vers.Text)) Then
            MessageBox.Show("No iOS version selected!")
        Else
            rootfs.Visible = True
            ramdsk.Visible = True
            rramdsk.Visible = True
            applelogo.Visible = True
            batchar0.Visible = True
            batchar1.Visible = True
            batfull.Visible = True
            batlow0.Visible = True
            batlow1.Visible = True
            devtree.Visible = True
            glphplug.Visible = True
            kernel.Visible = True
            ibec.Visible = True
            iboot.Visible = True
            ibss.Visible = True
            glphchar.Visible = True
            llb.Visible = True
            recovery.Visible = True
            RFkey.Visible = True
            BL0key.Visible = True
            BL0iv.Visible = True
            BL1key.Visible = True
            BL1iv.Visible = True
            URAMkey.Visible = True
            URAMiv.Visible = True
            KCkey.Visible = True
            KCiv.Visible = True
            BSSkey.Visible = True
            BSSiv.Visible = True
            BECkey.Visible = True
            BECiv.Visible = True
            BOOTkey.Visible = True
            BOOTiv.Visible = True
            ALkey.Visible = True
            ALiv.Visible = True
            RRkey.Visible = True
            RRiv.Visible = True
            BC0key.Visible = True
            BC0iv.Visible = True
            BC1key.Visible = True
            BC1iv.Visible = True
            BFkey.Visible = True
            BFiv.Visible = True
            DTkey.Visible = True
            DTiv.Visible = True
            GCkey.Visible = True
            GCiv.Visible = True
            GPkey.Visible = True
            GPiv.Visible = True
            RMkey.Visible = True
            RMiv.Visible = True
            LLBkey.Visible = True
            LLBiv.Visible = True
            Label3.Visible = True
        End If

        If dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 1.0" Then
            RFkey.Text = "28c909fc6d322fa18940f03279d70880e59a4507998347c70d5b8ca7ef090ecccc15e82d"
            BL0key.Text = "Not Encrypted"
            BL1key.Text = "Not Encrypted"
            URAMkey.Text = "Not Encrypted"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "Not Encrypted"
            ALkey.Text = "Not Encrypted"
            RRkey.Text = "Not Encrypted"
            BC0key.Text = "Not Encrypted"
            BC1key.Text = "Not Encrypted"
            BFkey.Text = "Not Encrypted"
            DTkey.Text = "Not Encrypted"
            GCkey.Text = "Not Encrypted"
            GPkey.Text = "Not Encrypted"
            RMkey.Text = "Not Encrypted"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "Not Encrypted"
            BL1iv.Text = "Not Encrypted"
            URAMiv.Text = "Not Encrypted"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "Not Encrypted"
            ALiv.Text = "Not Encrypted"
            RRiv.Text = "Not Encrypted"
            BC0iv.Text = "Not Encrypted"
            BC1iv.Text = "Not Encrypted"
            BFiv.Text = "Not Encrypted"
            DTiv.Text = "Not Encrypted"
            GCiv.Text = "Not Encrypted"
            GPiv.Text = "Not Encrypted"
            RMiv.Text = "Not Encrypted"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 1.0.1" Then
            RFkey.Text = "7d5962d0b582ec2557c2cade50de90f4353a1c1de07b74212513fef9cc71fb890574bfe5"
            BL0key.Text = "Not Encrypted"
            BL1key.Text = "Not Encrypted"
            URAMkey.Text = "Not Encrypted"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "Not Encrypted"
            ALkey.Text = "Not Encrypted"
            RRkey.Text = "Not Encrypted"
            BC0key.Text = "Not Encrypted"
            BC1key.Text = "Not Encrypted"
            BFkey.Text = "Not Encrypted"
            DTkey.Text = "Not Encrypted"
            GCkey.Text = "Not Encrypted"
            GPkey.Text = "Not Encrypted"
            RMkey.Text = "Not Encrypted"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "Not Encrypted"
            BL1iv.Text = "Not Encrypted"
            URAMiv.Text = "Not Encrypted"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "Not Encrypted"
            ALiv.Text = "Not Encrypted"
            RRiv.Text = "Not Encrypted"
            BC0iv.Text = "Not Encrypted"
            BC1iv.Text = "Not Encrypted"
            BFiv.Text = "Not Encrypted"
            DTiv.Text = "Not Encrypted"
            GCiv.Text = "Not Encrypted"
            GPiv.Text = "Not Encrypted"
            RMiv.Text = "Not Encrypted"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 1.0.2" Then
            RFkey.Text = "7d5962d0b582ec2557c2cade50de90f4353a1c1de07b74212513fef9cc71fb890574bfe5"
            BL0key.Text = "Not Encrypted"
            BL1key.Text = "Not Encrypted"
            URAMkey.Text = "Not Encrypted"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "vNot Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "Not Encrypted"
            ALkey.Text = "Not Encrypted"
            RRkey.Text = "Not Encrypted"
            BC0key.Text = "Not Encrypted"
            BC1key.Text = "Not Encrypted"
            BFkey.Text = "Not Encrypted"
            DTkey.Text = "Not Encrypted"
            GCkey.Text = "Not Encrypted"
            GPkey.Text = "Not Encrypted"
            RMkey.Text = "Not Encrypted"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "Not Encrypted"
            BL1iv.Text = "Not Encrypted"
            URAMiv.Text = "Not Encrypted"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "Not Encrypted"
            ALiv.Text = "Not Encrypted"
            RRiv.Text = "Not Encrypted"
            BC0iv.Text = "Not Encrypted"
            BC1iv.Text = "Not Encrypted"
            BFiv.Text = "vNot Encrypted"
            DTiv.Text = "Not Encrypted"
            GCiv.Text = "Not Encrypted"
            GPiv.Text = "Not Encrypted"
            RMiv.Text = "Not Encrypted"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 1.1.1" Then
            RFkey.Text = "f45de7637a62b200950e550f4144696d7ff3dc5f0b19c8efdf194c88f3bc2fa808fea3b3"
            BL0key.Text = "Not Encrypted"
            BL1key.Text = "Not Encrypted"
            URAMkey.Text = "Not Encrypted"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "Not Encrypted"
            ALkey.Text = "Not Encrypted"
            RRkey.Text = "Not Encrypted"
            BC0key.Text = "Not Encrypted"
            BC1key.Text = "Not Encrypted"
            BFkey.Text = "Not Encrypted"
            DTkey.Text = "Not Encrypted"
            GCkey.Text = "Not Encrypted"
            GPkey.Text = "Not Encrypted"
            RMkey.Text = "Not Encrypted"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "Not Encrypted"
            BL1iv.Text = "Not Encrypted"
            URAMiv.Text = "Not Encrypted"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "Not Encrypted"
            ALiv.Text = "Not Encrypted"
            RRiv.Text = "Not Encrypted"
            BC0iv.Text = "Not Encrypted"
            BC1iv.Text = "Not Encrypted"
            BFiv.Text = "Not Encrypted"
            DTiv.Text = "Not Encrypted"
            GCiv.Text = "Not Encrypted"
            GPiv.Text = "Not Encrypted"
            RMiv.Text = "Not Encrypted"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 1.1.2" Then
            RFkey.Text = "70e11d7209602ada5b15fbecc1709ad4910d0ad010bb9a9125b78f9f50e25f3e05c595e2"
            BL0key.Text = "Not Encrypted"
            BL1key.Text = "Not Encrypted"
            URAMkey.Text = "Not Encrypted"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "Not Encrypted"
            ALkey.Text = "Not Encrypted"
            RRkey.Text = "Not Encrypted"
            BC0key.Text = "Not Encrypted"
            BC1key.Text = "Not Encrypted"
            BFkey.Text = "Not Encrypted"
            DTkey.Text = "Not Encrypted"
            GCkey.Text = "Not Encrypted"
            GPkey.Text = "Not Encrypted"
            RMkey.Text = "Not Encrypted"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "Not Encrypted"
            BL1iv.Text = "Not Encrypted"
            URAMiv.Text = "Not Encrypted"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "Not Encrypted"
            ALiv.Text = "Not Encrypted"
            RRiv.Text = "Not Encrypted"
            BC0iv.Text = "Not Encrypted"
            BC1iv.Text = "Not Encrypted"
            BFiv.Text = "Not Encrypted"
            DTiv.Text = "Not Encrypted"
            GCiv.Text = "Not Encrypted"
            GPiv.Text = "Not Encrypted"
            RMiv.Text = "Not Encrypted"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 1.1.3" Then
            RFkey.Text = "11070c11d93b9be5069b643204451ed95aad37df7b332d10e48fd3d23c62fca517055816"
            BL0key.Text = "Not Encrypted"
            BL1key.Text = "Not Encrypted"
            URAMkey.Text = "Not Encrypted"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "Not Encrypted"
            ALkey.Text = "Not Encrypted"
            RRkey.Text = "Not Encrypted"
            BC0key.Text = "Not Encrypted"
            BC1key.Text = "Not Encrypted"
            BFkey.Text = "Not Encrypted"
            DTkey.Text = "Not Encrypted"
            GCkey.Text = "Not Encrypted"
            GPkey.Text = "Not Encrypted"
            RMkey.Text = "Not Encrypted"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "Not Encrypted"
            BL1iv.Text = "Not Encrypted"
            URAMiv.Text = "Not Encrypted"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "Not Encrypted"
            ALiv.Text = "Not Encrypted"
            RRiv.Text = "Not Encrypted"
            BC0iv.Text = "Not Encrypted"
            BC1iv.Text = "Not Encrypted"
            BFiv.Text = "Not Encrypted"
            DTiv.Text = "Not Encrypted"
            GCiv.Text = "Not Encrypted"
            GPiv.Text = "Not Encrypted"
            RMiv.Text = "Not Encrypted"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 1.1.4" Then
            RFkey.Text = "d0a0c0977bd4b6350b256d6650ec9eca419b6f961f593e74b7e5b93e010b698ca6cca1fe"
            BL0key.Text = "Not Encrypted"
            BL1key.Text = "Not Encrypted"
            URAMkey.Text = "Not Encrypted"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "Not Encrypted"
            ALkey.Text = "Not Encrypted"
            RRkey.Text = "Not Encrypted"
            BC0key.Text = "Not Encrypted"
            BC1key.Text = "Not Encrypted"
            BFkey.Text = "Not Encrypted"
            DTkey.Text = "Not Encrypted"
            GCkey.Text = "Not Encrypted"
            GPkey.Text = "Not Encrypted"
            RMkey.Text = "Not Encrypted"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "Not Encrypted"
            BL1iv.Text = "Not Encrypted"
            URAMiv.Text = "Not Encrypted"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "Not Encrypted"
            ALiv.Text = "Not Encrypted"
            RRiv.Text = "Not Encrypted"
            BC0iv.Text = "Not Encrypted"
            BC1iv.Text = "Not Encrypted"
            BFiv.Text = "Not Encrypted"
            DTiv.Text = "Not Encrypted"
            GCiv.Text = "Not Encrypted"
            GPiv.Text = "Not Encrypted"
            RMiv.Text = "Not Encrypted"
            LLBiv.Text = "Not Encrypted"


            'iPhone 2G
        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 2.0" Then
            RFkey.Text = "2cfca55aabb22fde7746e6a034f738b7795458be9902726002a8341995558990f41e3755"
            BL0key.Text = "82ada2c6ded2d09c3641dce0a6e3b994"
            BL1key.Text = "5710d5ed5ecb579dc5ce19637968329a"
            URAMkey.Text = "No info"
            KCkey.Text = "e8a54cb7b34773d67a2e6540c588129f"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "6ee2b333ca5848970af891caa0cb7a6a"
            ALkey.Text = "94bf8963c8ef945e919adb1ee38f8d74"
            RRkey.Text = "850afc271132d15ae6989565567e65bf"
            BC0key.Text = "No info"
            BC1key.Text = "No info"
            BFkey.Text = "No info"
            DTkey.Text = "462631c8489390443f82665a6d257c6a"
            GCkey.Text = "855bbebec01ed2f1e939370645863fac"
            GPkey.Text = "117f24929aa7c66e67d5ead2a0972780"
            RMkey.Text = "94bd127dfec81a27a486d599b821875e"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "aa35ebd31aa4b234942c82c9cc554da2"
            BL1iv.Text = "8a75fd316a6ed1c50ee361560b3d2ff0"
            URAMiv.Text = "No info"
            KCiv.Text = "3525bab8a8375143469c5c6a4533d9bc"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "1306ced060ed795ccb410271eef06259"
            ALiv.Text = "5d1c8f19b86411f032d647de174ca7cd"
            RRiv.Text = "29681f625d1f61271ec3116601b8bcde"
            BC0iv.Text = "No info"
            BC1iv.Text = "No info"
            BFiv.Text = "No info"
            DTiv.Text = "ad41f2ba3bc2f722acdf168e6730d375"
            GCiv.Text = "6aad442a5849a45688fbcd7bc409ab9c"
            GPiv.Text = "b2866546a751f9d6557c37e761c28401"
            RMiv.Text = "1007fd4b6d504082573ae48d96fa88e7"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 2.0.1" Then
            RFkey.Text = "2cfca55aabb22fde7746e6a034f738b7795458be9902726002a8341995558990f41e3755"
            BL0key.Text = "b41941f8d30bc06e2268a7e89eb2c018"
            BL1key.Text = "bd80bf6f43aa13c7e6518faee262e3ab"
            URAMkey.Text = "fc0dfb4d99bfb020621f28f3d6ed774b"
            KCkey.Text = "444f19d072e725f8a27d88ce50ce73de"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "dedefcf601e83b05dcd36bce41b83e5e"
            ALkey.Text = "4b69f6c9eed042cacf89fc575ff3b193"
            RRkey.Text = "ace2eff2c089a51328c9ec5040e1238d"
            BC0key.Text = "No info"
            BC1key.Text = "No info"
            BFkey.Text = "No info"
            DTkey.Text = "26d739a57194a59926edb4112798c447"
            GCkey.Text = "497914be358babb79cad2877fed02add"
            GPkey.Text = "e69a0d9f9fba2e33269c140d54cc5223"
            RMkey.Text = "2e5d3470a5a1c9ab8b6c7c334569e86f"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "f0408fd6dc0778876c58fb59d37d44b1"
            BL1iv.Text = "3ce0dd810dbad8b90407a57acca80ff2"
            URAMiv.Text = "e33d5c7af40422bb32a9e522cb0448b0"
            KCiv.Text = "285df0aa00b76e8c0b9870a4dd7bd5f6"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "2e3a392e8c2e0e5c9f00ef4c23259596"
            ALiv.Text = "bf67cfba9160ad7dbdf44f2baf176458"
            RRiv.Text = "0e1504c70c2b7eabe2488a5bf7b1ac60"
            BC0iv.Text = "No info"
            BC1iv.Text = "No info"
            BFiv.Text = "No info"
            DTiv.Text = "45254ae98f0e3460e5190812ac627b15"
            GCiv.Text = "28bebce29b48781aafc9b5109dccc83f"
            GPiv.Text = "a6ece338e8db3eefa4a38201c8e5033f"
            RMiv.Text = "285df0aa00b76e8c0b9870a4dd7bd5f6"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 2.0.2" Then
            RFkey.Text = "31e3ff09ff046d5237187346ee893015354d2135e3f0f39480be63dd2a18444961c2da5d"
            BL0key.Text = "b41941f8d30bc06e2268a7e89eb2c018"
            BL1key.Text = "bd80bf6f43aa13c7e6518faee262e3ab"
            URAMkey.Text = "cc028fd29dc27f895e401d9865e72100"
            KCkey.Text = "Not Encrypted"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "dedefcf601e83b05dcd36bce41b83e5e"
            ALkey.Text = "4b69f6c9eed042cacf89fc575ff3b193"
            RRkey.Text = "3635e76652cd326c3005a6eb48e549cc"
            BC0key.Text = "No info"
            BC1key.Text = "No info"
            BFkey.Text = "No info"
            DTkey.Text = "26d739a57194a59926edb4112798c447"
            GCkey.Text = "497914be358babb79cad2877fed02add"
            GPkey.Text = "e69a0d9f9fba2e33269c140d54cc5223"
            RMkey.Text = "2e5d3470a5a1c9ab8b6c7c334569e86f"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "f0408fd6dc0778876c58fb59d37d44b1"
            BL1iv.Text = "3ce0dd810dbad8b90407a57acca80ff2"
            URAMiv.Text = "537eb4e7129ea81f572ec23dbec42b80"
            KCiv.Text = "Not Encrypted"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "2e3a392e8c2e0e5c9f00ef4c23259596"
            ALiv.Text = "bf67cfba9160ad7dbdf44f2baf176458"
            RRiv.Text = "cbafeb5d381dcba6a6dd94edc3b63bfe"
            BC0iv.Text = "No info"
            BC1iv.Text = "No info"
            BFiv.Text = "No info"
            DTiv.Text = "45254ae98f0e3460e5190812ac627b15"
            GCiv.Text = "28bebce29b48781aafc9b5109dccc83f"
            GPiv.Text = "a6ece338e8db3eefa4a38201c8e5033f"
            RMiv.Text = "0e1504c70c2b7eabe2488a5bf7b1ac60"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 2.1" Then
            RFkey.Text = "562ca0f7963eafb462da74a9c1f01a45c30a7eb5f1f493feceecae03ee6521a334f4ff68"
            BL0key.Text = "3ba1dcc3c2884e458a1dccf399673240"
            BL1key.Text = "b2e0d1a9abcb357a195db400d9b8850d"
            URAMkey.Text = "d77bd81b9d1adc01fe540eecd885547b"
            KCkey.Text = "de52cebf74b7747360535fde5c331bd1"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "3fe2f270daaeb5debb1d7fe748db42d8"
            ALkey.Text = "97bfa5c532bf1cef85a147c9eb78e77a"
            RRkey.Text = "42b4f39976afa59f9ec680fccd2c7d04"
            BC0key.Text = "No info"
            BC1key.Text = "No info"
            BFkey.Text = "No info"
            DTkey.Text = "4f140e2e56f32e923e75502e734834ce"
            GCkey.Text = "2fdfd8ab501fd282119a9512e0baf49b"
            GPkey.Text = "e9d3ffcd6d0407d474f422c8b44bab45"
            RMkey.Text = "e54dede9164129300cf0c6a6a0232ce8"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "095cb632f03188472155550a5afaca96"
            BL1iv.Text = "9d873607198be55fe05279660f475ddf"
            URAMiv.Text = "4b9a4d90965381c1fec08922f7242644"
            KCiv.Text = "2b4764d4c5bdeaa4cea2100eac7c47bb"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "12a18540363aad4f446b264d11ae2692"
            ALiv.Text = "c9721629a4d994932c802f4277a9bcee"
            RRiv.Text = "fd530c4cf8a878f16387432988b199b8"
            BC0iv.Text = "No info"
            BC1iv.Text = "No info"
            BFiv.Text = "No info"
            DTiv.Text = "e7a5c596612f2cae195f8c4cca19da9a"
            GCiv.Text = "d8f06a161d85531d03d2a866cb08ddb4"
            GPiv.Text = "d7b54d4ac934dca7f0bf435c1506463e"
            RMiv.Text = "80a64935155a9af54e39fb7c0aa52bd1"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 2.2" Then
            RFkey.Text = "dc39d88afe4cbd8a3f36824b8fd68acf04ac72718c09100816c5cb89889b8079e96802f0"
            BL0key.Text = "347a35e53f936eb6a76112c3de56f63d"
            BL1key.Text = "fb3250f9433cb413a02d29e29bad763a"
            URAMkey.Text = "4cce03e3467e5c830f1ac8bd9cabe8ae"
            KCkey.Text = "a3ad8e780bc8148e8e6299d3352b96bc"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "11ea57ea0251b3f82a1ea93a3f7a3e03"
            ALkey.Text = "4157f794afedbb68b6e3d40771b23fd8"
            RRkey.Text = "eea6e87824a3c0b0be86e8e2bbd8cfe9"
            BC0key.Text = "No info"
            BC1key.Text = "No info"
            BFkey.Text = "No info"
            DTkey.Text = "31ef1f82d256b0a2669f2eb3db7dddfa"
            GCkey.Text = "8d4acfabf47b0ba2dd70af01f9bfb342"
            GPkey.Text = "d7b6f56ae49e9eb88d86969b89e35426"
            RMkey.Text = "f26e84c8d9ea34ea913608b47d66bdf7"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "fd10a31c79f918ec20af73c455f6d2bf"
            BL1iv.Text = "1d497957422addb26108475b1401def8"
            URAMiv.Text = "93c059c2116e1957a3c414ec336b1d27"
            KCiv.Text = "ff4c66886a10aaea2a8fff0f70dd201a"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "fde10ab322ea13f48e24ef2af203aa92"
            ALiv.Text = "24b311c220a2d5947e45c37a24e91c90"
            RRiv.Text = "182cdda90a38870de96880ee7ff5bbbc"
            BC0iv.Text = "No info"
            BC1iv.Text = "No info"
            BFiv.Text = "No info"
            DTiv.Text = "741806a00deb32a1f7bef875be912a78"
            GCiv.Text = "79c6b415cc8c233177a6d40cd9eb7da4"
            GPiv.Text = "fc10cd58956424909018635a5fa48c59"
            RMiv.Text = "46f155e69a37cbbf2b6c81fd1fe7a9c7"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 2.2.1" Then
            RFkey.Text = "ee4eeeb62240c1378c739696dff9fef2c88834e98877f55a29c147e7d5b137967197392a"
            BL0key.Text = "6a5adb8b2f560527ff9fa0a3f04ec09d"
            BL1key.Text = "b1537f8943e0fde45703e5e97ffc1f70"
            URAMkey.Text = "2d2b3f82677a71cdc7f038abc5e8c7d0"
            KCkey.Text = "f6f00f9369bb19855b9a3d0a69e15a2d"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "01678a11c6bcd564271c7c05d5cce4a0"
            ALkey.Text = "b10c2c9c6eb9f750564b46c83ae2d7c7"
            RRkey.Text = "da010f69b0e2034b4ce7b7c90b63bad5"
            BC0key.Text = "No info"
            BC1key.Text = "No info"
            BFkey.Text = "No info"
            DTkey.Text = "7a16997fe453d89206f1ef8c75890c15"
            GCkey.Text = "3ff300a21236477ae015ca5a3a1c4c35"
            GPkey.Text = "41d85d6098e19eb38a4c327c5c983c1f"
            RMkey.Text = "46ab218dab1d7704e008d165c35aaeac"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "5c7680438b7f7c41d825438939d21f25"
            BL1iv.Text = "6a5adb8b2f560527ff9fa0a3f04ec09d"
            URAMiv.Text = "4118a23cfea0b5b4e09fa2664acbf719"
            KCiv.Text = "661f05d1599967135b86e82e2377b58d"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "1446bd26ee8932fcb78d6dbedf894664"
            ALiv.Text = "a51b9842b29d057096142a2ad79ae7f0"
            RRiv.Text = "29ff3d43c4001b978963dee437e25386"
            BC0iv.Text = "No info"
            BC1iv.Text = "No info"
            BFiv.Text = "No info"
            DTiv.Text = "c3f3d2707409fe28164a442bb839a803"
            GCiv.Text = "6d466e39c5d5df2b18459746943e35f9"
            GPiv.Text = "489c01632c3e9fd57e328aa0b09dc825"
            RMiv.Text = "232d64600a89d970fd4e12795ae17dbf"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 3.0" Then
            RFkey.Text = "25cce378de209d8fb6ec45ecbe7525695272b81fe38bbad76e979ac3921c3614ed162c87"
            BL0key.Text = "a3f0c602763852309469648116df4722"
            BL1key.Text = "6eb1142e1f77f87687da00c796e4eb61"
            URAMkey.Text = "5a0f82979f336baa58ed37926bd89dfe"
            KCkey.Text = "02418105dfb3be2af2a76248e026f702"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "2dd3199489ba2f671494527d1c9c6424"
            ALkey.Text = "f9841fa3197f0bd9fd162ce170c5f6f9"
            RRkey.Text = "9962589aabb4d5ec56b7a867ab5b11b0"
            BC0key.Text = "a3f0c602763852309469648116df4722"
            BC1key.Text = "6eb1142e1f77f87687da00c796e4eb61"
            BFkey.Text = "e518c7f9df797bc7a9c5e7256a6a85dd"
            DTkey.Text = "e564420353b18c7e4c380d6528a2ee6b"
            GCkey.Text = "f5a6ae904d976741cbefabd527f5027c"
            GPkey.Text = "689f91dab29610b6064e450901f3d87f"
            RMkey.Text = "5a56972f4750335c448f3219269ed202"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "6ed7927936a0b7227ade1cae7baf6a8d"
            BL1iv.Text = "eb3a27a0d16927a3be24bf4f7e75df21"
            URAMiv.Text = "0dc67d4f50ac62ee142b99baa569d0f4"
            KCiv.Text = "a4db9183cd79722b4146c9de09ab29c5"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "f791669bbcae1aabec772b9dd2bdd8c8"
            ALiv.Text = "30c0cb05ae49d0484392261b2c8b21a8"
            RRiv.Text = "9962589aabb4d5ec56b7a867ab5b11b0"
            BC0iv.Text = "dce93ec9df98cf590c0b792bcbccca8b"
            BC1iv.Text = "0c794909235d360af8a2aad92b92c281"
            BFiv.Text = "04bb4dd56ca411dd5a6c4cff06eac5e3"
            DTiv.Text = "6c190b94d74681d8bff4c069054b7057"
            GCiv.Text = "c62f0a6d0c296b1859599a614ecabd80"
            GPiv.Text = "38ff24afa0422c6be244ea0be00ce12d"
            RMiv.Text = "848d4cef8e4d8182c3f10062cf5347fe"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 3.0.1" Then
            RFkey.Text = "b40c24a019b995593b89594fa0866e5e2a5ff2e052bb98c134025f9ab01c554056fb16a6"
            BL0key.Text = "b6a8c1a9b7dc523146558422305e2237"
            BL1key.Text = "7bf6775691685437193e089299979171"
            URAMkey.Text = "e4d7c7f324c55f8a31e863eae539c668"
            KCkey.Text = "5bf1ea6596f26dc37ee2b2b6a43e1320"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "2dd3199489ba2f671494527d1c9c6424"
            ALkey.Text = "f9841fa3197f0bd9fd162ce170c5f6f9"
            RRkey.Text = "3bb4e6ec9117ea60cfcf4649d296bea9"
            BC0key.Text = "a3f0c602763852309469648116df4722"
            BC1key.Text = "6eb1142e1f77f87687da00c796e4eb61"
            BFkey.Text = "e518c7f9df797bc7a9c5e7256a6a85dd"
            DTkey.Text = "e564420353b18c7e4c380d6528a2ee6b"
            GCkey.Text = "f5a6ae904d976741cbefabd527f5027c"
            GPkey.Text = "689f91dab29610b6064e450901f3d87f"
            RMkey.Text = "5a56972f4750335c448f3219269ed202"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "6ed7927936a0b7227ade1cae7baf6a8d"
            BL1iv.Text = "eb3a27a0d16927a3be24bf4f7e75df21"
            URAMiv.Text = "b45759a73c69f440733a5a258a09a86f"
            KCiv.Text = "63680cd8965137a064a3d19a689a80b3"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "f791669bbcae1aabec772b9dd2bdd8c8"
            ALiv.Text = "30c0cb05ae49d0484392261b2c8b21a8"
            RRiv.Text = "391949ef28cd2f20aa06f04e0e621c72"
            BC0iv.Text = "dce93ec9df98cf590c0b792bcbccca8b"
            BC1iv.Text = "0c794909235d360af8a2aad92b92c281"
            BFiv.Text = "04bb4dd56ca411dd5a6c4cff06eac5e3"
            DTiv.Text = "6c190b94d74681d8bff4c069054b7057"
            GCiv.Text = "c62f0a6d0c296b1859599a614ecabd80"
            GPiv.Text = "38ff24afa0422c6be244ea0be00ce12d"
            RMiv.Text = "848d4cef8e4d8182c3f10062cf5347fe"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 3.1" Then
            RFkey.Text = "dbe476ed0d8c1ecf7cd514463f2ca5a6f71b6f244d98ebaa9203fd527c1ecbf2bb5f143f"
            BL0key.Text = "c1bcd4b18161303135f386a5b3f5b645"
            BL1key.Text = "79fcf4f159a5fbfef5baaaa347926720"
            URAMkey.Text = "8ab278e2094fcdfe05e6c29c778595e0"
            KCkey.Text = "258303b6d261e6476de63bc9f185b9f0"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "7e63651dd73d09da6a28544d7986cab7"
            ALkey.Text = "1f15304209b7fc8c36651e86a1adb1cf"
            RRkey.Text = "081091184b13fb72ffd91d19dce9b199"
            BC0key.Text = "1f15304209b7fc8c36651e86a1adb1cf"
            BC1key.Text = "91872731b7ffb34e34300f5785711d7b"
            BFkey.Text = "9962b39f775d6941109d0ca06f22cbe5"
            DTkey.Text = "32d083ffab527f87a8ed4553970dcdd3"
            GCkey.Text = "cc53f9fc36f1a3efc02b490fdba035e1"
            GPkey.Text = "83e6c7256fc5444b592ccbe67d1a950a"
            RMkey.Text = "2648aeb9ab66fe6f2c0fbfd571d1ebc0"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "fe5b6ad072835ba24d4a513768882355"
            BL1iv.Text = "e812b8e53545874e8727dcc39e01e2fa"
            URAMiv.Text = "71f6eb862e503153d7cfaca2bd035077"
            KCiv.Text = "612726fff1a589a3a8906dd6b1129e86"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "70ac4d428c1f9ff9a0ea48f84ae87728"
            ALiv.Text = "1b8a5224f45aa94cfc02a8ceba55d6d8"
            RRiv.Text = "73b1c28fc8fbfc6860cfb5f65962a71c"
            BC0iv.Text = "9dc5cb4730b7ff858336144f34fb130c"
            BC1iv.Text = "5a0973cc7b5229220a3bb897bdfc463a"
            BFiv.Text = "06bf68bef1bf08c803760992f06d82df"
            DTiv.Text = "e75fcb72f5cdb49b614250c89f6f7e2f"
            GCiv.Text = "63a79f76df4d1abc8d07d3a01cc47b5a"
            GPiv.Text = "38ff24afa0422c6be244ea0be00ce12d"
            RMiv.Text = "d28b9cb54a828d5259dc588f19cf3302"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 3.1.2" Then
            RFkey.Text = "fe431a1e436e5298d3c871359768aab43189fd5e7375a2ced3405dd8a223879a4d64a28e"
            BL0key.Text = "08bb04ffc5fbdf0552c47276e39ea15f"
            BL1key.Text = "c5e5604dc32a6a1ebe947b85d97775f9"
            URAMkey.Text = "998aa71f7816e979697b2d4b25e6a8a0"
            KCkey.Text = "dd03b5b52a53d3582b18a0052ef84038"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "a0ae133d5de080b4341d3eeb8aff63d4"
            ALkey.Text = "1fb738d6c091113d7dfdd89864a718d9"
            RRkey.Text = "6a4db11073eb748bad1fabafb066fe13"
            BC0key.Text = "700ac0237ad0e7c8c09bbfb032869a11"
            BC1key.Text = "717d08aca631fe7cf1c72faf10bfa5e2"
            BFkey.Text = "14be236d0770304b1a3cee7ef6c3ee1c"
            DTkey.Text = "c7cab2ad412e0bfad844c84bb8e22001"
            GCkey.Text = "4e3ed0ef0df688197c48663058a3abd2"
            GPkey.Text = "0193270305e3a3fe4ae7abe7091682dd"
            RMkey.Text = "6d7d035c04c60ab2776a5e7c729daf0a"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "bda02a558e2c2ea772018a538284de0b"
            BL1iv.Text = "9197c05fcf74a95666787e0a344b9153"
            URAMiv.Text = "dc2c487fd5ce7d89c2fcfbec5846f40f"
            KCiv.Text = "25b7f586d184c329d3d05953a6516a36"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "db240b5ba6163898bbbc055be2276ea0"
            ALiv.Text = "677b4c711e3cacb72505feae8e1eae5d"
            RRiv.Text = "0e128e1f69806afc476b73250908d641"
            BC0iv.Text = "b2bb770f2627f5f91c887d2900422979"
            BC1iv.Text = "32f47e1fb326271dde768cc77b9b19d2"
            BFiv.Text = "1516dfa70e4139b8330fdb95cf7b1106"
            DTiv.Text = "7a705e2e9ae1615db089e9265d965698"
            GCiv.Text = "949d2235d5aa716d6332abc22db317ef"
            GPiv.Text = "b47e791f67129f74b6e9cb2a4863c6ec"
            RMiv.Text = "dbf44c3cc2944b87bdecdbdcd8e42b82"
            LLBiv.Text = "Not Encrypted"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 2G" And vers.Text = "iOS 3.1.3" Then
            RFkey.Text = "3c0f821663316c08a0a059c2979ecf47d13b363de3a44010d0de0b0a5cf878cfe39d00c3"
            BL0key.Text = "7a2f4af7bfad3190a119533432e4ea79"
            BL1key.Text = "3b2abd9b9b4cc7ed6e9981ba208f129c"
            URAMkey.Text = "05ad3977f313f7efaf9263bb33915af0"
            KCkey.Text = "d0dfac22c03212f8a75fc9c69fe548b6"
            BSSkey.Text = "Not Encrypted"
            BECkey.Text = "Not Encrypted"
            BOOTkey.Text = "57baddbdf7d64453e26c1dec97027f9e"
            ALkey.Text = "f991b79dc86f1ed7d997785b4e93c0b9"
            RRkey.Text = "7029389c2dadaaa1d1e51bf579493824"
            BC0key.Text = "5c5e265adf97ff887f83c1964cd26fbc"
            BC1key.Text = "3e94246a2893d04223b960ec163a0d1f"
            BFkey.Text = "92669d64fb9ea886317d8c38b3cf88cd"
            DTkey.Text = "29d6801ad7829e31c1f8c6b98fa076ef"
            GCkey.Text = "4efaa97201e0be8eebc633be2bd8e80e"
            GPkey.Text = "51e76b6183f5de42988cd3f983714c11"
            RMkey.Text = "72e3360fae2d22252f497bd08d060d83"
            LLBkey.Text = "Not Encrypted"
            BL0iv.Text = "18c4cc5b9881a7f46fb6816b6bf98621"
            BL1iv.Text = "43046878e50b200c94208e71d54d7d46"
            URAMiv.Text = "28f586f972f37ada68ccb1db9c0809d7"
            KCiv.Text = "31e711201cf4dcf47be5be2a5b1b87a1"
            BSSiv.Text = "Not Encrypted"
            BECiv.Text = "Not Encrypted"
            BOOTiv.Text = "768745fc3d6984e6d6938b819426a3cb"
            ALiv.Text = "29900b1381b112bc6ca157b8d5e533fb"
            RRiv.Text = "25e713dd5663badebe046d0ffa164fee"
            BC0iv.Text = "4a7131c4e4ab53c54c9cd67000022c0c"
            BC1iv.Text = "d95821f8d527c863bc83384b2a49d70f"
            BFiv.Text = "b510390a90fe02ba01fc72e25bc4bed0"
            DTiv.Text = "6b36a5f109ef5e6dc77f03ba3e8567c7"
            GCiv.Text = "f063514314d014e962d072d144869448"
            GPiv.Text = "e2cbdecb935e44022411251450e09e25"
            RMiv.Text = "1df103ab51af7ad9f8488d9e3b9edf11"
            LLBiv.Text = "Not Encrypted"

            'iPhone 4S
        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 4S" And vers.Text = "iOS 5.0" Then
            RFkey.Text = "d40e28ae28f41418e6e1586c4bb575731995e8f873d0b37efa9601f252982ef82961200d"
            BL0key.Text = "66a3ee21af45dd01dd7f55d9402ad5e314d8b34dfa9ff3dce04d1f10d4104f6c"
            BL1key.Text = "4c51a9d10834be604afc1c2dde14739764b226676d5e77d1d0f2505867e293a2"
            URAMkey.Text = "No info"
            KCkey.Text = "b0ac12f65eff43866bfe997b5758e3bcf76db1e2cf31a1c118cc01c8be8c041e"
            BSSkey.Text = "10c94f6633f7ed3806d79b1f1232bb8b7e1650b8702318281932dd25662966eb"
            BECkey.Text = "7d0584f3d2e1e6a8f32de2614bc48263c1672dd8c52855664d2a86ee25b4b535"
            BOOTkey.Text = "11c1381279f6d14fa428afa6ecb05db2008dee42710fffccb7d1823f95c5712e"
            ALkey.Text = "19a23a4ba6e89d1c1610b74d758a3bd40e8c0dca065a7de8feb17cb419d750ea"
            RRkey.Text = "6de13de0bb4d5a742bf3e50707edad9b9b6739c6e03986c760873070427d24c8"
            BC0key.Text = "87437b6530c904689b448da365cf27bf70c40b6d9bf73c9c89b5afb0933b3788"
            BC1key.Text = "30d1850e27c4ecd3855f369f884988f0d6fa2afbe204ea1d6ed8e3008f69c1d9"
            BFkey.Text = "b8562106d4bfe336b8a7a6ec1aa2a1ecd707528bb5a3d1996561f05bc6e79a3a"
            DTkey.Text = "7b809ade8dbbd5865598f7047af87ea90469a77f137006c3954a549fb4bab083"
            GCkey.Text = "72159b6eded8d2a8ad1f8eb69125cec4048efb7e01132a66cb88b255581dacf0"
            GPkey.Text = "402a6a5954824c14329244e4f801b4683469bca2416ad1ddcfa962f02304271e"
            RMkey.Text = "080046f9f7fe23806d192a78b013a27fa10f3a0945445bc02e9e130683563f1b"
            LLBkey.Text = "3987eefb0bf8065809fc133a0003d5c5fc27dd3391dd56da4a406198cd4846d6"
            BL0iv.Text = "8c636fa8986e686abbf36bd6e12e3e31"
            BL1iv.Text = "b577ee2554be4a43398568f12071d633"
            URAMiv.Text = "No info"
            KCiv.Text = "87920b1023053b1fdc45e50df3d001fc"
            BSSiv.Text = "9fd4bce1849332063e4dd345b2031ef0"
            BECiv.Text = "aa157c3b2535193287bca02e48cb602b"
            BOOTiv.Text = "8b9dcb253351b4caa4a4e2eb3a866b2b"
            ALiv.Text = "2cdb712073b24159755415c93fb110f4"
            RRiv.Text = "c35bb5d204d20f4d2e7475c0fb8c111a"
            BC0iv.Text = "4ee3714f33838df545dbe7d8051cd0e6"
            BC1iv.Text = "82bdfb17a193c7565bfc675fb57bffb9"
            BFiv.Text = "972b81dd9b87dca3ee141dbe2cc82220"
            DTiv.Text = "79369b6cade94fda78614f83522c5735"
            GCiv.Text = "75d45a1372cb17b0661d8fb38e75bf16"
            GPiv.Text = "b4a24d85ab7b588ec215084f895cbbbd"
            RMiv.Text = "63a194b05abb0cd01177a572df1de7eb"
            LLBiv.Text = "732f8776ee71621142ac64a044eb0c92"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 4S" And vers.Text = "iOS 5.0.1 (nov)" Then
            RFkey.Text = "ae2f6c90b714d073e39bdf2443af0c0cec4fe9d172b2bd70e52a20a86185ad0378d4f40e"
            BL0key.Text = "a010d3a9cec630a5b34fa77e87c354b379ff6e5fbb6318f7516ce1f37d83938d"
            BL1key.Text = "4b4d8f94c5a4089b186a77f1c5ce134307346ba6c0c262fb03422f744e9e60c2"
            URAMkey.Text = "8cf8152ce23d75e0a23068eede85548d647e890d7fb355b7d78d2fed1ff74ef6"
            KCkey.Text = "a9f30d0d73c4a100775224f2effdfeaa77f09ce7b169285b5414bae86130096c"
            BSSkey.Text = "008fe19488b3fe05e134a515e1b18dd349c7f4f376a804dc39219bef29e59094"
            BECkey.Text = "77d3ee6303477dc1bcdd4c164ea4ef2d5a543cbe3a83195cc3c9c1d90d9dda02"
            BOOTkey.Text = "6740c8353b45303b25a0a0ed19f4f999e5a068b5e5280054a74b9bcaedb11f0e"
            ALkey.Text = "29964bb87ae63547a108fb268d6bf07a69f1603c086ae3b47d7323a3ed8157c2"
            RRkey.Text = "509ce2aed62965f88016f06fd07a29075d9e9ef8d9f8c1851d73b009644e256b"
            BC0key.Text = "ef294fd5745f8ba75ab1032585cf21c0b59b5e957ac652bffda6aa09b8b31246"
            BC1key.Text = "521ecff4c85d9bcec80d4ffdd62f9376c09e7d5a8d6174b2db9bdcb138e0d431"
            BFkey.Text = "f0f435dcb11d5950440f78a6041931b556ca07e7937dfbff7906090f2a138b1c"
            DTkey.Text = "368d8c42fb194ee56456f153d18bc4c0f2a6e423e297e1e5056a8bca3fb83f95"
            GCkey.Text = "0d3e36aee54b5775d01a0b1aeccbcbdcb10c6c583f099bd3eeefc8824d530e16"
            GPkey.Text = "7cfce6d0550acf1bd75bb21f2efd8f15ff7f5a4fc2495642ede2b67b13c2a9f6"
            RMkey.Text = "2f20bf0ec057bd83eb341d2169e93eaac12e1b2c6a5cfa817621ffae202aceff"
            LLBkey.Text = "a1e910dd924e2840796b5b433c5a81a1437ce3e2850fa6cf4bea4bbc243d78ed"
            BL0iv.Text = "d327e08fa6ae79d13f753966ee8a1636"
            BL1iv.Text = "a4d487d54dfe684622a44c8d153eb561"
            URAMiv.Text = "81a604631e577419e99b9b6d44e21bce"
            KCiv.Text = "e0aa065963c34279d4fabe0e750e5f07"
            BSSiv.Text = "a7dfbb5c7f8cc13f0a2cc1891d5dbb21"
            BECiv.Text = "9f586d7b708fe7d2d83976014d9fba84"
            BOOTiv.Text = "247b01c72b5dbc1806f2af56d5749e28"
            ALiv.Text = "84aafefd3a67e7726d515382d5532405"
            RRiv.Text = "b59c87fd76ec8d91b5458c6c432ca56c"
            BC0iv.Text = "802e4bfed5854238636dccf3eae136e4"
            BC1iv.Text = "c505624db6b3a4eccf3d7cff9c6caa9b"
            BFiv.Text = "c836958a8b0e11b93c0611978d618c8a"
            DTiv.Text = "5d1b02236bb6764532730f10dd05597b"
            GCiv.Text = "401c059fe6419e2e1c1ac7c129c7a18b"
            GPiv.Text = "bef365ebebb991571f39c53a904fb7f6"
            RMiv.Text = "7f465404a6e2a037a69222521d53af02"
            LLBiv.Text = "31b544606b6c6a5ba692769abceef058"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 4S" And vers.Text = "iOS 5.0.1 (dec)" Then
            RFkey.Text = "a31ffd506c6711c5a0c52c9f0a2f7208a2f63ad9dd40506e70d80ea20a981eb1312bc774"
            BL0key.Text = "a010d3a9cec630a5b34fa77e87c354b379ff6e5fbb6318f7516ce1f37d83938d"
            BL1key.Text = "4b4d8f94c5a4089b186a77f1c5ce134307346ba6c0c262fb03422f744e9e60c2"
            URAMkey.Text = "Not encrypted!"
            KCkey.Text = "ed45eda61316a2bc6caf05317504f99d457df59740e098a99d08081810e376e6"
            BSSkey.Text = "008fe19488b3fe05e134a515e1b18dd349c7f4f376a804dc39219bef29e59094"
            BECkey.Text = "77d3ee6303477dc1bcdd4c164ea4ef2d5a543cbe3a83195cc3c9c1d90d9dda02"
            BOOTkey.Text = "6740c8353b45303b25a0a0ed19f4f999e5a068b5e5280054a74b9bcaedb11f0e"
            ALkey.Text = "29964bb87ae63547a108fb268d6bf07a69f1603c086ae3b47d7323a3ed8157c2"
            RRkey.Text = "Not encrypted!"
            BC0key.Text = "ef294fd5745f8ba75ab1032585cf21c0b59b5e957ac652bffda6aa09b8b31246"
            BC1key.Text = "521ecff4c85d9bcec80d4ffdd62f9376c09e7d5a8d6174b2db9bdcb138e0d431"
            BFkey.Text = "f0f435dcb11d5950440f78a6041931b556ca07e7937dfbff7906090f2a138b1c"
            DTkey.Text = "368d8c42fb194ee56456f153d18bc4c0f2a6e423e297e1e5056a8bca3fb83f95"
            GCkey.Text = "0d3e36aee54b5775d01a0b1aeccbcbdcb10c6c583f099bd3eeefc8824d530e16"
            GPkey.Text = "7cfce6d0550acf1bd75bb21f2efd8f15ff7f5a4fc2495642ede2b67b13c2a9f6"
            RMkey.Text = "2f20bf0ec057bd83eb341d2169e93eaac12e1b2c6a5cfa817621ffae202aceff"
            LLBkey.Text = "a1e910dd924e2840796b5b433c5a81a1437ce3e2850fa6cf4bea4bbc243d78ed"
            BL0iv.Text = "d327e08fa6ae79d13f753966ee8a1636"
            BL1iv.Text = "a4d487d54dfe684622a44c8d153eb561"
            URAMiv.Text = "Not encrypted!"
            KCiv.Text = "0a22d254292cdfb584d8e1fdc92c45eb"
            BSSiv.Text = "a7dfbb5c7f8cc13f0a2cc1891d5dbb21"
            BECiv.Text = "9f586d7b708fe7d2d83976014d9fba84"
            BOOTiv.Text = "247b01c72b5dbc1806f2af56d5749e28"
            ALiv.Text = "84aafefd3a67e7726d515382d5532405"
            RRiv.Text = "b59c87fd76ec8d91b5458c6c432ca56c"
            BC0iv.Text = "802e4bfed5854238636dccf3eae136e4"
            BC1iv.Text = "c505624db6b3a4eccf3d7cff9c6caa9b"
            BFiv.Text = "c836958a8b0e11b93c0611978d618c8a"
            DTiv.Text = "5d1b02236bb6764532730f10dd05597b"
            GCiv.Text = "401c059fe6419e2e1c1ac7c129c7a18b"
            GPiv.Text = "bef365ebebb991571f39c53a904fb7f6"
            RMiv.Text = "7f465404a6e2a037a69222521d53af02"
            LLBiv.Text = "31b544606b6c6a5ba692769abceef058"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 4S" And vers.Text = "iOS 5.1" Then
            RFkey.Text = "fc432b225c62c1aeeebcfa1fec6c95360e887e018534c3e21a98f2450f0b22928e8af536"
            BL0key.Text = "827912f6b82718671bc2b47b027925a859a1775f96f53b947aa677f22933bf68"
            BL1key.Text = "ba9e175654039582bf6dfa891ca42da32cb800e11b055de567e56492f09679a9"
            URAMkey.Text = "0c27b842343c2ab58580369d0abe1a2da2a319ab74c39b17e6f88113a90a8bd1"
            KCkey.Text = "cbb4ccb0b19e102369d9790f3e79b914fc50ad25ddaeb70d8d7314eeec4cf0eb"
            BSSkey.Text = "25a3fba1936817b53d5df34d881049c3b48279baaa250a926352a394eae791f4"
            BECkey.Text = "1e893d8c59fcb2042e2777f9db7dfc65b8801a1142cd56e5cdddc58ef95929da"
            BOOTkey.Text = "e96fbc5902029c97a8278f863ef09bad273c6cddca675739b83e84bf2d948a56"
            ALkey.Text = "d517fb5d6ef15a191e0eec7269615b9c90709da47af1530b7cc0c1c7af03825f"
            RRkey.Text = "4912305df4a958099ffe70f7cee2c5eab7edd22241c248adf82c5370430acbb6"
            BC0key.Text = "c7c62e54bb6d5152dd3688619fa7fdfbf650c9f6e67536a9556d3a3cbaee580b"
            BC1key.Text = "c8d4bd848928e6fa0c5b5a9fdd836686a59bc014a8d9590f7d85ce9e7335bc79"
            BFkey.Text = "6e840ea48f39830c4180825a2361069b903dd7a25257504d609be2dc72f4a7d6"
            DTkey.Text = "ad3386987c2600af647827279fa2a484b30d3c51d6be7a61674aed5816842c93"
            GCkey.Text = "14b12745e26f7bb1e8d51cf157ac4acbee8647dd2946509d8fc155c15954ca17"
            GPkey.Text = "73910f1905f8824be6983beb3245dac92927f18229dbe03021c97d35e11790b6"
            RMkey.Text = "4faab527c925c37ad00caaefb8d239d46a0d546c4595888d771eb07d5e3c9ec2"
            LLBkey.Text = "1e99e6dd120777c319904aec9cf64dbb57b37da07c2e9bb97e88b9a5a81c756b"
            BL0iv.Text = "da75db97584909a413b9b35ad06f9ee2"
            BL1iv.Text = "91e98a633c0900cc3a611e7f72f6461c"
            URAMiv.Text = "810abc70b9d4515a6e668cbf6b2724e9"
            KCiv.Text = "08c7f1591e14f2723e6af891aee71dcb"
            BSSiv.Text = "8db33e11ab5c5b81cd813d1f367a2e5c"
            BECiv.Text = "fb7b6c119c1fef65bf604d26cae9eb70"
            BOOTiv.Text = "be165593144508c4aceb9cb9f00206c4"
            ALiv.Text = "6a9510488b178cddfef07aacd0f79d41"
            RRiv.Text = "4912305df4a958099ffe70f7cee2c5eab7edd22241c248adf82c5370430acbb6"
            BC0iv.Text = "c35d59a8e9b1c4b6b9d28dcf7ce0a048"
            BC1iv.Text = "dd7d72cfaed9e67b61f97c88562f7c80"
            BFiv.Text = "e9cf57b8d1de39690c83f3bb48a6b4cc"
            DTiv.Text = "05015cdfa2d2443ce345b59eab9fb23b"
            GCiv.Text = "fd76579ae5a1bc0af70aae770ad21a03"
            GPiv.Text = "94e43070348b1eb3affafc6184da0643"
            RMiv.Text = "550abdde19c99ac86d1f6e0e68be3575"
            LLBiv.Text = "e504b9352cad5345197ab71e426c7e9a"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 4S" And vers.Text = "iOS 5.1.1" Then
            RFkey.Text = "812b2ca06fb59273fb15cf7acfaec59b300e103fa8df1987ef99d7b74124e660d7d40fb2"
            BL0key.Text = "827912f6b82718671bc2b47b027925a859a1775f96f53b947aa677f22933bf68"
            BL1key.Text = "ba9e175654039582bf6dfa891ca42da32cb800e11b055de567e56492f09679a9"
            URAMkey.Text = "f91fc6c171d2d8c684e86bb249a2016923f9f1d9c17b5a2fee2f27aafb05ef23"
            KCkey.Text = "d9e1f955fade0b20e63567243653164f0977b77324d4815c8f4c2bd5eceb7aff"
            BSSkey.Text = "25a3fba1936817b53d5df34d881049c3b48279baaa250a926352a394eae791f4"
            BECkey.Text = "1e893d8c59fcb2042e2777f9db7dfc65b8801a1142cd56e5cdddc58ef95929da"
            BOOTkey.Text = "e96fbc5902029c97a8278f863ef09bad273c6cddca675739b83e84bf2d948a56"
            ALkey.Text = "d517fb5d6ef15a191e0eec7269615b9c90709da47af1530b7cc0c1c7af03825f"
            RRkey.Text = "92465acf6ddad6b675591294f34b95947477c5a14718facd5401062f55f4ebca"
            BC0key.Text = "c7c62e54bb6d5152dd3688619fa7fdfbf650c9f6e67536a9556d3a3cbaee580b"
            BC1key.Text = "c8d4bd848928e6fa0c5b5a9fdd836686a59bc014a8d9590f7d85ce9e7335bc79"
            BFkey.Text = "6e840ea48f39830c4180825a2361069b903dd7a25257504d609be2dc72f4a7d6"
            DTkey.Text = "ad3386987c2600af647827279fa2a484b30d3c51d6be7a61674aed5816842c93"
            GCkey.Text = "14b12745e26f7bb1e8d51cf157ac4acbee8647dd2946509d8fc155c15954ca17"
            GPkey.Text = "73910f1905f8824be6983beb3245dac92927f18229dbe03021c97d35e11790b6"
            RMkey.Text = "4faab527c925c37ad00caaefb8d239d46a0d546c4595888d771eb07d5e3c9ec2"
            LLBkey.Text = "1e99e6dd120777c319904aec9cf64dbb57b37da07c2e9bb97e88b9a5a81c756b"
            BL0iv.Text = "da75db97584909a413b9b35ad06f9ee2"
            BL1iv.Text = "91e98a633c0900cc3a611e7f72f6461c"
            URAMiv.Text = "ad209848907a2084497e69fca6d72bec"
            KCiv.Text = "4b3455932a2c1e6d77ed4b99900eb43f"
            BSSiv.Text = "8db33e11ab5c5b81cd813d1f367a2e5c"
            BECiv.Text = "fb7b6c119c1fef65bf604d26cae9eb70"
            BOOTiv.Text = "be165593144508c4aceb9cb9f00206c4"
            ALiv.Text = "6a9510488b178cddfef07aacd0f79d41"
            RRiv.Text = "4912305df4a958099ffe70f7cee2c5eab7edd22241c248adf82c5370430acbb6"
            BC0iv.Text = "c35d59a8e9b1c4b6b9d28dcf7ce0a048"
            BC1iv.Text = "dd7d72cfaed9e67b61f97c88562f7c80"
            BFiv.Text = "e9cf57b8d1de39690c83f3bb48a6b4cc"
            DTiv.Text = "05015cdfa2d2443ce345b59eab9fb23b"
            GCiv.Text = "fd76579ae5a1bc0af70aae770ad21a03"
            GPiv.Text = "94e43070348b1eb3affafc6184da0643"
            RMiv.Text = "550abdde19c99ac86d1f6e0e68be3575"
            LLBiv.Text = "e504b9352cad5345197ab71e426c7e9a"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 4S" And vers.Text = "iOS 6.0" Then
            RFkey.Text = "21e902c9271917f5fd20da31c3b1e89b1818c1546db9032b36482e3d6726b0f83fa45a17"
            BL0key.Text = "11af4980e1284a7cdaf03788ed6fe6f61db303ecd37b7bf04ba711b81caeb30c"
            BL1key.Text = "dbf29b8d8f3ec517103fc04e5290ebd9e1a23b98267f42d01fdef5c1b4b44388"
            URAMkey.Text = "3000949d24aff9c18f92b7a7e467af3f8af030a678c8c3e7dbc3bcabc5645855"
            KCkey.Text = "0368f01ba0b6c8f7bdef6efb82dbd90e40eb13467008c682ca9338f872013907"
            BSSkey.Text = "cd3a8ffca03859844b1bbc809a1e068df319afbd847453f27958a3c734d09f52"
            BECkey.Text = "6c764f79c8ac0f775a41a6e99de09860a0f8f5f478e5433e8dbd14f6aa959a44"
            BOOTkey.Text = "eda6d90a9c75948701644e3efd61ca7b524819ff35a5137a99b0d6d1ee10f983"
            ALkey.Text = "6fe6f5797c04d077e6e14ac04f66bb8b8bcc493450ff335d708478f1732fab30"
            RRkey.Text = "4b8c380e31322dbb1f51dc39979687722b45e0e85539d307fdaaa556d0fde7af"
            BC0key.Text = "746a3663b3f5233583fef7ffba998d420dcaf85a163b3ff714ddbda7fd89acaa"
            BC1key.Text = "78d4f025a33ed7ece71ef4e86e9103575a21021e95527ef43fd515f461a1a354"
            BFkey.Text = "b4720a7fc620b11e0619386473d31f3e5b9e81c00de885df7d7cc78a45d0505b"
            DTkey.Text = "eb5657347635d84459fd935400f861a80463d53ecc2aceb69ae1e938501499a8"
            GCkey.Text = "0a5f35f3a587df738420ab05ed1b38b71bac46e4061473ab3f8426955d90cc7b"
            GPkey.Text = "604a91095ef07e8597db158b38c9b6dd8175aaa17cee23ccbcd62f27b9c40e0d"
            RMkey.Text = "3a5d224a97c8b0f65f263e06998afd045f7685246f3cd08e7a6f1b96aecb77d7"
            LLBkey.Text = "3df5952947101ec2c805547d3055569dfe5f46cbc210429e760f3b1126b0604a"
            BL0iv.Text = "c6a613c3cd9b20d58acf258269f59472"
            BL1iv.Text = "dea4181994df38a850b862285344dba3"
            URAMiv.Text = "75accbe9bb6e8ce0a169c2d693f92a5d"
            KCiv.Text = "8dcd3575e5fd5acdf6590ceb6ed3bdc9"
            BSSiv.Text = "219977f4df2d5468b9b9201232437fab"
            BECiv.Text = "61e462d591adb56130d58f17cfd11522"
            BOOTiv.Text = "c949cd93f6a4f68d33560ccbc9afa62e"
            ALiv.Text = "4d9f018790f93859948a1539db06dee9"
            RRiv.Text = "c91272b20b7d3097020bd2e8802f2548"
            BC0iv.Text = "a8f51ea306af6e24cae4a7053e979d2c"
            BC1iv.Text = "5e574fa08b0954f39c06287b016b2055"
            BFiv.Text = "83521db08d714c34ba93aeeba91ca7cd"
            DTiv.Text = "24648d62f2f97c23f76ad306010ab535"
            GCiv.Text = "711aa24291436694b8f36fb8ad982d4d"
            GPiv.Text = "e038f5a16cf3d00174de58c1a6fb19d8"
            RMiv.Text = "38e48f5fb4631b5b1119764ed6658e5f"
            LLBiv.Text = "05ca926bf3aa497e3df80beafcdb5808"

        ElseIf dev.Text = "iPhone" And model.Text = "iPhone 4S" And vers.Text = "iOS 6.0.1" Then
            RFkey.Text = "21e902c9271917f5fd20da31c3b1e89b1818c1546db9032b36482e3d6726b0f83fa45a17"
            BL0key.Text = "11af4980e1284a7cdaf03788ed6fe6f61db303ecd37b7bf04ba711b81caeb30c"
            BL1key.Text = "dbf29b8d8f3ec517103fc04e5290ebd9e1a23b98267f42d01fdef5c1b4b44388"
            URAMkey.Text = "3000949d24aff9c18f92b7a7e467af3f8af030a678c8c3e7dbc3bcabc5645855"
            KCkey.Text = "0368f01ba0b6c8f7bdef6efb82dbd90e40eb13467008c682ca9338f872013907"
            BSSkey.Text = "cd3a8ffca03859844b1bbc809a1e068df319afbd847453f27958a3c734d09f52"
            BECkey.Text = "6c764f79c8ac0f775a41a6e99de09860a0f8f5f478e5433e8dbd14f6aa959a44"
            BOOTkey.Text = "eda6d90a9c75948701644e3efd61ca7b524819ff35a5137a99b0d6d1ee10f983"
            ALkey.Text = "6fe6f5797c04d077e6e14ac04f66bb8b8bcc493450ff335d708478f1732fab30"
            RRkey.Text = "4b8c380e31322dbb1f51dc39979687722b45e0e85539d307fdaaa556d0fde7af"
            BC0key.Text = "746a3663b3f5233583fef7ffba998d420dcaf85a163b3ff714ddbda7fd89acaa"
            BC1key.Text = "78d4f025a33ed7ece71ef4e86e9103575a21021e95527ef43fd515f461a1a354"
            BFkey.Text = "b4720a7fc620b11e0619386473d31f3e5b9e81c00de885df7d7cc78a45d0505b"
            DTkey.Text = "eb5657347635d84459fd935400f861a80463d53ecc2aceb69ae1e938501499a8"
            GCkey.Text = "0a5f35f3a587df738420ab05ed1b38b71bac46e4061473ab3f8426955d90cc7b"
            GPkey.Text = "604a91095ef07e8597db158b38c9b6dd8175aaa17cee23ccbcd62f27b9c40e0d"
            RMkey.Text = "3a5d224a97c8b0f65f263e06998afd045f7685246f3cd08e7a6f1b96aecb77d7"
            LLBkey.Text = "3df5952947101ec2c805547d3055569dfe5f46cbc210429e760f3b1126b0604a"
            BL0iv.Text = "c6a613c3cd9b20d58acf258269f59472"
            BL1iv.Text = "dea4181994df38a850b862285344dba3"
            URAMiv.Text = "75accbe9bb6e8ce0a169c2d693f92a5d"
            KCiv.Text = "8dcd3575e5fd5acdf6590ceb6ed3bdc9"
            BSSiv.Text = "219977f4df2d5468b9b9201232437fab"
            BECiv.Text = "61e462d591adb56130d58f17cfd11522"
            BOOTiv.Text = "c949cd93f6a4f68d33560ccbc9afa62e"
            ALiv.Text = "4d9f018790f93859948a1539db06dee9"
            RRiv.Text = "c91272b20b7d3097020bd2e8802f2548"
            BC0iv.Text = "a8f51ea306af6e24cae4a7053e979d2c"
            BC1iv.Text = "5e574fa08b0954f39c06287b016b2055"
            BFiv.Text = "83521db08d714c34ba93aeeba91ca7cd"
            DTiv.Text = "24648d62f2f97c23f76ad306010ab535"
            GCiv.Text = "711aa24291436694b8f36fb8ad982d4d"
            GPiv.Text = "e038f5a16cf3d00174de58c1a6fb19d8"
            RMiv.Text = "38e48f5fb4631b5b1119764ed6658e5f"
            LLBiv.Text = "05ca926bf3aa497e3df80beafcdb5808"

            'iPads here
            'iPad 1
        ElseIf dev.Text = "iPad" And model.Text = "iPad 1" And vers.Text = "iOS 3.2" Then
            RFkey.Text = "2be8f3a0a02f2d259c9b297cb2d156a85adf79fed4ffe88c546a42c2a47aa55f70cadebd"
            BL0key.Text = "57b7d7753f9012b5cff48af4c13ce0f0425e84f1a2360f7904baac9e366b975a"
            BL1key.Text = "28ae9a4e2d29e144fd91784ec7f09b226961def938577ff539fd307981be512c"
            URAMkey.Text = "2cc7f6ba799ffadbec51238847a8154157a14013ed6be5b8a25c77d9da476395"
            KCkey.Text = "8c80ca1a1fb8a1f87b6dfa34d186fd235118025029c0aa8df6a70bd33987c146"
            BSSkey.Text = "eb3c9eabd45eb5701fe1998d570fa38a31ba2807918345a5c7efe0fff7ce1bea"
            BECkey.Text = "d127363289fe0b1b2d6b9f758b0616f0c6751e2b870cc434ac34a57ef64858fa"
            BOOTkey.Text = "1e3a1ca2f45d15452b16b9fe0a2c214a0af897f09ee269f8e5967fc74b1022ac"
            ALkey.Text = "f6a6c39e8ea1c2bf9d2bd4eef2e7ef4d0d0611d86a6d8511c625b58042e8e31e"
            RRkey.Text = "31e7ecd9c364414205a8fa0092cc80c0d67eae40e75ffa27b37048c42335a106"
            BC0key.Text = "f9fef3eebf4bec7ae5165aa97ecbbe1bdf5abe03e79d6c8e5e87cbac78a9e535"
            BC1key.Text = "c2ec30e2843b11540e98657e16b482d30070231accf67373fe895bb5e41089e9"
            BFkey.Text = "3b51f2658e2e84b90dd6cff40e723653c207af9afc8f8e59047fe56282041ae3"
            DTkey.Text = "2b5a61188dd993997da958d56b08ae55aea4362a5d29fceb627de91150199d75"
            GCkey.Text = "6de70e3bf8c2ae5e716e584b1b68d57d30629086e494503772c5fc0ca8bac9f3"
            GPkey.Text = "2d4f8322fc622e26493e332518511a9d4d186b6219b111763b06c7534fa08ad0"
            RMkey.Text = "efdc580c591f125c1e75e7230333e6f4848eac02fe67546dfb430de43c6b1886"
            LLBkey.Text = "2ad3f34c1a8530802fe4f301d90c88423a6cccd57614844815f085ab8c9bbeef"
            BL0iv.Text = "39018f4c7614bb324c90b34a593a4996"
            BL1iv.Text = "8c141f550b8b019bfea9377bd9632536"
            URAMiv.Text = "ac36df9b6d4a8d6c76cfd1dc542ec77d"
            KCiv.Text = "0ce08a45b54f54bb99f12e582122b992"
            BSSiv.Text = "b83ba3ecc1919d4dc80a560230b80910"
            BECiv.Text = "5e0b3d5aee240120e0c6dcc64034324f"
            BOOTiv.Text = "36e1bcd042ac193f7305c8e6077d3df7"
            ALiv.Text = "e839ae241b3c2010a13c2031973f7310"
            RRiv.Text = "9c051576ddd94f48c324cf7ac3197fe1"
            BC0iv.Text = "0a33ce75fa4d27332d8d2d3cec282baf"
            BC1iv.Text = "0fad5bc049fb7902c47dabd9e4014e64"
            BFiv.Text = "13c130314ee35dfc242c4c5ad9496ba8"
            DTiv.Text = "0e3fdb2cd018eaab38b427b34cbf556d"
            GCiv.Text = "a908f13bd3f0cc21200160aaa0534b6e"
            GPiv.Text = "fc3e56a76dfbbb1821fa7e4d18e9b8e0"
            RMiv.Text = "b863b29507dfc1e7a6de474638ca2966"
            LLBiv.Text = "c85cf15d8242b5bba914ad3506a37dde"

        ElseIf dev.Text = "iPad" And model.Text = "iPad 1" And vers.Text = "iOS 3.2.1" Then
            RFkey.Text = "c3d15c6dc3b289db4d90b59199c485486043bb534c14d21993e35f68f2c6c1804a9125a8"
            BL0key.Text = "b6ea4e0377f87f3b0f5cc53ce8557560b33af64d0cf5a02fbf1e58cde0b72d80"
            BL1key.Text = "72a8537c4f1858ea7969190ddb297b48a7ccbe63bf929c4826e437b60f3f0ebc"
            URAMkey.Text = "a4a2396bc7329f7f5a905c6725253f3ffad2da650f9b6c827021bbd9335757b3"
            KCkey.Text = "0453c9edf37057aed0469ba0dea629e8b7f02dd58879ceb0092782767a805d2f"
            BSSkey.Text = "0dcdc5bdc0d991020222c0e7b7d11305466f0ef831964c5fc9325f05e32b1a09"
            BECkey.Text = "11d18ab20469d399c1bfc0a30159499024eb393b5fe4fecdf6b049e119071fed"
            BOOTkey.Text = "8eb56b03a0e081dd175d3d076c5b07eca73847d27c93186783059728a1a1831d"
            ALkey.Text = "aae7b027f6d797b0a95459a13b1c0d9749f2279a5de4356239ddf34ede15fd39"
            RRkey.Text = "aa616f53beff0bd86dfb7aa53954614395fc13e31be97fb16e0f886f0d6cdcfc"
            BC0key.Text = "1312baba3b441ff21c1ab71bedb812747613b59aa09d04e323de52ab0f61129b"
            BC1key.Text = "f0b999bf581a0dee8863a53ec78b5dc6e5f4f3b22ac1351581507884922d7eb8"
            BFkey.Text = "1077d59ceeae77e6ec6b380fcecd0e6922a24c50c61116af9a7ac183779da042"
            DTkey.Text = "21395bd5848bea1df6a18b62de234b4bb3b9ce67b7fd6a4e6a968780e805a1a3"
            GCkey.Text = "850a70fe9fb050c934424ae8c39293d239d89bef523246993cddc40c8cfd3a63"
            GPkey.Text = "bd23381af4381f8bbb4ec816361b1f072e5be37542ca53d6afdb8b0e9c5d726c"
            RMkey.Text = "dfc2bb2afdcb7b9ab1cd67da8de051fb4f32b851d42444edfe8bbedf5c36a2b3"
            LLBkey.Text = "910fd0fd2bb43ad4aad2496a835c2c90f62aa6fda61419b087187f19c25b5959"
            BL0iv.Text = "db114d8b404363aa0a093ef96eb8b2ae"
            BL1iv.Text = "5c82e6ac3d35183cf1a0c78523c35f6e"
            URAMiv.Text = "ac20e399c6e3e491b68028ccdd51b458"
            KCiv.Text = "9e86cf4fe0422c1ccffe7679c5bed7d3"
            BSSiv.Text = "3a0ad7cf0f172bc3736af2099a4a89b4"
            BECiv.Text = "7cc0fcf856d754d163efafa7ab751ef1"
            BOOTiv.Text = "1fde75187fea653b42170b71c9b4844e"
            ALiv.Text = "743a4d54b0da0b23662885bd6a8a9ce1"
            RRiv.Text = "3ed149b2f67690e5376880fc0323fbe2"
            BC0iv.Text = "ca2515a2fbfcfab8ce7a47b6cba1b876"
            BC1iv.Text = "7503542226c2798c39f703505820aa60"
            BFiv.Text = "fce6ea7541baca8b3003791d2efc155c"
            DTiv.Text = "3f48a3e3a7bc563824a488fbd1f51639"
            GCiv.Text = "70f5515133cab74d5852956d4e26d8b1"
            GPiv.Text = "51ad1b46301e2bcd9ddfe6b4a775a29a"
            RMiv.Text = "9d88f32f9cbda46d323d85add8292bec"
            LLBiv.Text = "a00118ed3a126fe16781a080f2b1d6bd"

        ElseIf dev.Text = "iPad" And model.Text = "iPad 1" And vers.Text = "iOS 3.2.2" Then
            RFkey.Text = "18ae1e76e7bcf6478321f42888606ca2d998cffab1ee8c7ca6b15d57b1a7254f8a608823"
            BL0key.Text = "b6ea4e0377f87f3b0f5cc53ce8557560b33af64d0cf5a02fbf1e58cde0b72d80"
            BL1key.Text = "72a8537c4f1858ea7969190ddb297b48a7ccbe63bf929c4826e437b60f3f0ebc"
            URAMkey.Text = "3188be37002aef49c9f54d91da23857f89045118c2bb1e6f1db906c98dbb5230"
            KCkey.Text = "f8a5166b935ab9593872065cc25ea2b3824ddc3799a83b47e55d1d046d0522ac"
            BSSkey.Text = "0dcdc5bdc0d991020222c0e7b7d11305466f0ef831964c5fc9325f05e32b1a09"
            BECkey.Text = "11d18ab20469d399c1bfc0a30159499024eb393b5fe4fecdf6b049e119071fed"
            BOOTkey.Text = "8eb56b03a0e081dd175d3d076c5b07eca73847d27c93186783059728a1a1831d"
            ALkey.Text = "aae7b027f6d797b0a95459a13b1c0d9749f2279a5de4356239ddf34ede15fd39"
            RRkey.Text = "f45eaec8b6c17af7c6071635a313572b1b0208bc445cfb6c1d60b6bf377e6653"
            BC0key.Text = "1312baba3b441ff21c1ab71bedb812747613b59aa09d04e323de52ab0f61129b"
            BC1key.Text = "f0b999bf581a0dee8863a53ec78b5dc6e5f4f3b22ac1351581507884922d7eb8"
            BFkey.Text = "1077d59ceeae77e6ec6b380fcecd0e6922a24c50c61116af9a7ac183779da042"
            DTkey.Text = "21395bd5848bea1df6a18b62de234b4bb3b9ce67b7fd6a4e6a968780e805a1a3"
            GCkey.Text = "850a70fe9fb050c934424ae8c39293d239d89bef523246993cddc40c8cfd3a63"
            GPkey.Text = "bd23381af4381f8bbb4ec816361b1f072e5be37542ca53d6afdb8b0e9c5d726c"
            RMkey.Text = "dfc2bb2afdcb7b9ab1cd67da8de051fb4f32b851d42444eDfe8bbedf5c36a2b3"
            LLBkey.Text = "910fd0fd2bb43ad4aad2496a835c2c90f62aa6fda61419b087187f19c25b5959"
            BL0iv.Text = "db114d8b404363aa0a093ef96eb8b2ae"
            BL1iv.Text = "5c82e6ac3d35183cf1a0c78523c35f6e"
            URAMiv.Text = "3f6f0bdb71a33c801a9b67a616e9cfe3"
            KCiv.Text = "f89438cd21803ce315d98c032c4e6c27"
            BSSiv.Text = "3a0ad7cf0f172bc3736af2099a4a89b4"
            BECiv.Text = "7cc0fcf856d754d163efafa7ab751ef1"
            BOOTiv.Text = "1fde75187fea653b42170b71c9b4844e"
            ALiv.Text = "743a4d54b0da0b23662885bd6a8a9ce1"
            RRiv.Text = "309d4fc146b47f43e8bc27133d7ce6bc"
            BC0iv.Text = "ca2515a2fbfcfab8ce7a47b6cba1b876"
            BC1iv.Text = "7503542226c2798c39f703505820aa60"
            BFiv.Text = "fce6ea7541baca8b3003791d2efc155c"
            DTiv.Text = "3f48a3e3a7bc563824a488fbd1f51639"
            GCiv.Text = "70f5515133cab74d5852956d4e26d8b1"
            GPiv.Text = "51ad1b46301e2bcd9ddfe6b4a775a29a"
            RMiv.Text = "9d88f32f9cbda46d323d85add8292bec"
            LLBiv.Text = "a00118ed3a126fe16781a080f2b1d6bd"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Credits to:
theiphonewiki.com - keys
@MrSkellytone - creating Windows app
@AaroniusLeonius - MacOS app
r/visualbasic - for helping with the code")
    End Sub

End Class
