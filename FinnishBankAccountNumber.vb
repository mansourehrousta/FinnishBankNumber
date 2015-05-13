Class FinnishBankAccountNumber
    Dim ZeroChar As String = String.Empty 'Include the needed zeros to be added
    Dim ZeroLength As Integer 'Number of additional zeros need to be added
    Dim bstring As String 'First digit of the given number
    Private _p1 As String 'Contents of the textbox
    Dim lenn As String    'The length of text  
    Dim cstring As String 'Output string of label3

    Sub New(p1 As String)
        _p1 = p1
    End Sub

    Function getLongFormat() As String
        'Throw New NotImplementedException
        lenn = _p1.Length
        bstring = _p1.Substring(0, 1)
        Select Case bstring
            Case 1, 2, 3, 6, 8
                If lenn >= 8 Then
                    ZeroChar = String.Empty
                    ZeroLength = 14 - _p1.Length
                    ZeroChar = ZeroChar.PadLeft(ZeroLength, "0")
                    cstring = _p1.Insert(6, ZeroChar)
                ElseIf lenn < 8 Then ' Handles incorrect Input
                    MessageBox.Show("Enter a correct number")
                    cstring = "ERROR"
                End If
            Case 4, 5
                If lenn >= 8 Then
                    ZeroChar = String.Empty
                    ZeroLength = 14 - _p1.Length
                    ZeroChar = ZeroChar.PadLeft(ZeroLength, "0")
                    cstring = _p1.Insert(7, ZeroChar)
                ElseIf lenn < 8 Then 'Handles incorrect Input
                    MessageBox.Show("Enter a correct number")
                    cstring = "ERROR"
                End If
            Case Else 'Handles incorrect Input
                MessageBox.Show("Enter a correct number")
                cstring = "ERROR"
        End Select
        Return cstring
    End Function

End Class
