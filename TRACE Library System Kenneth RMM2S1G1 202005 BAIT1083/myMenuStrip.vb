Module myMenuStrip
    Public myBGColor As System.Drawing.Color = System.Drawing.Color.AntiqueWhite
    Public myTextColor As System.Drawing.Color = System.Drawing.Color.Maroon

    Friend Sub lightmode()
        myBGColor = System.Drawing.Color.AntiqueWhite
        myTextColor = System.Drawing.Color.Maroon
    End Sub

    Friend Sub darkmode()
        myBGColor = System.Drawing.Color.Gray
        myTextColor = System.Drawing.Color.White
    End Sub

End Module
