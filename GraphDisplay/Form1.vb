Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Static PubBITMAP As Bitmap
        If PubBITMAP Is Nothing Then
            PubBITMAP = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        End If

        Call DrawGp(PubBITMAP)

        PictureBox1.Image = PubBITMAP

    End Sub

    Private Sub DrawGp(ByVal GetBITMAP As System.Drawing.Bitmap)

        Dim ds As DrawSet = DrawInit(GetBITMAP)

        For EleX As Integer = GetBITMAP.Width * -1 To GetBITMAP.Width

            Dim NowPosX As Integer
            Dim NowPosY As Integer

            NowPosX = EleX

            'ここが一次関数
            NowPosY = NowPosX * 10 + 100

            DrawXY(ds, NowPosX, NowPosY)
        Next

        'リソースを解放する
        ds.g.Dispose()

    End Sub

    Structure DrawSet
        Dim g As System.Drawing.Graphics
        Dim XMax As Integer
        Dim YMax As Integer
        Dim XPos As Integer
        Dim YPos As Integer
        Dim LastPosX As Integer
        Dim LastPosY As Integer
    End Structure
    Private Function DrawInit(ByVal GetBITMAP As System.Drawing.Bitmap) As DrawSet

        Dim ds As DrawSet

        ds.g = System.Drawing.Graphics.FromImage(GetBITMAP)

        ds.XMax = GetBITMAP.Width
        ds.YMax = GetBITMAP.Height
        ds.XPos = GetBITMAP.Width / 2
        ds.YPos = GetBITMAP.Height / 2
        ds.LastPosX = -1
        ds.LastPosY = -1

        ds.g.FillRectangle(Brushes.White, New Rectangle(0, 0, ds.XMax, ds.YMax))

        For WrkStep As Integer = 0 To ds.YPos Step 20

            Dim WrkPens As System.Drawing.Pen
            If WrkStep = 0 Then
                WrkPens = Pens.SeaGreen
            Else
                WrkPens = Pens.SkyBlue
            End If

            ds.g.DrawLine(WrkPens, 0, ds.YPos + WrkStep, ds.XMax, ds.YPos + WrkStep)
            ds.g.DrawLine(WrkPens, 0, ds.YPos + WrkStep * -1, ds.XMax, ds.YPos + WrkStep * -1)
        Next
        For WrkStep As Integer = 0 To ds.XPos Step 20

            Dim WrkPens As System.Drawing.Pen
            If WrkStep = 0 Then
                WrkPens = Pens.SeaGreen
            Else
                WrkPens = Pens.SkyBlue
            End If

            ds.g.DrawLine(WrkPens, ds.XPos + WrkStep, 0, ds.XPos + WrkStep, ds.YMax)
            ds.g.DrawLine(WrkPens, ds.XPos + WrkStep * -1, 0, ds.XPos + WrkStep * -1, ds.YMax)

        Next

        Return ds
    End Function
    Private Sub DrawXY(ByRef ds As DrawSet, ByVal X As Integer, ByVal Y As Integer)

        Y = Y * -1

        If ds.LastPosX = -1 Then
            ds.LastPosX = X
            ds.LastPosY = Y
        End If

        'ds.g.DrawRectangle(Pens.Black, ds.XPos + X, ds.YPos + Y, 1, 1)
        ds.g.DrawLine(Pens.Black, ds.XPos + ds.LastPosX, ds.YPos + ds.LastPosY, ds.XPos + X, ds.YPos + Y)

        ds.LastPosX = X
        ds.LastPosY = Y

    End Sub

End Class
