Option Explicit On '型宣言を強制
Option Strict On 'タイプ変換を厳密に

Public Class GraphPicture
    Inherits PictureBox

    Delegate Function GrapthFunction(ByVal NowPosX As Double) As Double

    Public Sub DrawGraph(ByVal WrkGrapthFunction As GrapthFunction)

        Dim WrkBITMAP As Bitmap = New Bitmap(Me.Width, Me.Height)

        Dim ds As DrawSet = DrawInit(WrkBITMAP)

        Dim NowPosY As Double
        For NowPosX As Double = WrkBITMAP.Width * -1 To WrkBITMAP.Width

            ''ここが一次関数
            'NowPosY = NowPosX * 10 + 100

            'ここが2次関数
            'NowPosY = NowPosX * NowPosX * 0.1 - 50
            'NowPosY = NowPosX ^ 2 * -0.01 + 150

            '関数実行
            NowPosY = WrkGrapthFunction(NowPosX)

            DrawXY(ds, CInt(NowPosX), CInt(NowPosY))
        Next

        'リソースを解放する
        ds.g.Dispose()

        Me.Image = WrkBITMAP

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
        ds.XPos = GetBITMAP.Width \ 2
        ds.YPos = GetBITMAP.Height \ 2
        ds.LastPosX = -1
        ds.LastPosY = -1

        ds.g.FillRectangle(Brushes.White, New Rectangle(0, 0, ds.XMax, ds.YMax))

        '横方眼線
        For WrkStep As Integer = 0 To ds.YPos Step 20

            Dim WrkPens As System.Drawing.Pen
            If WrkStep = 0 Then
                WrkPens = Pens.LightGreen
            Else
                WrkPens = Pens.PaleTurquoise
            End If

            ds.g.DrawLine(WrkPens, 0, ds.YPos + WrkStep, ds.XMax, ds.YPos + WrkStep)
            If WrkStep <> 0 Then '緑の線は１回描画するだけで良いので条件追加
                ds.g.DrawLine(WrkPens, 0, ds.YPos + WrkStep * -1, ds.XMax, ds.YPos + WrkStep * -1)
            End If
        Next

        '縦方眼線
        For WrkStep As Integer = 0 To ds.XPos Step 20

            Dim WrkPens As System.Drawing.Pen
            If WrkStep = 0 Then
                WrkPens = Pens.LightGreen
            Else
                WrkPens = Pens.PaleTurquoise
            End If

            ds.g.DrawLine(WrkPens, ds.XPos + WrkStep, 0, ds.XPos + WrkStep, ds.YMax)
            If WrkStep <> 0 Then '緑の線は１回描画するだけで良いので条件追加
                ds.g.DrawLine(WrkPens, ds.XPos + WrkStep * -1, 0, ds.XPos + WrkStep * -1, ds.YMax)
            End If

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
