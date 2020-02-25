Option Explicit On '型宣言を強制
Option Strict On 'タイプ変換を厳密に

Public Class Form1

    '一次関数
    Private Sub LinearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinearBtn.Click
        Call GraphPicture1.DrawGraph(AddressOf GrapthFunctionLinear)
    End Sub
    Private Function GrapthFunctionLinear(ByVal NowPosX As Double) As Double

        Dim NowPosY As Double

        'ここが一次関数
        NowPosY = CDbl(TextBox2.Text) * NowPosX + CDbl(TextBox1.Text)

        Return NowPosY
    End Function

    '２次関数
    Private Sub QuadraticBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuadraticBtn.Click
        Call GraphPicture1.DrawGraph(AddressOf GrapthFunctionQuadratic)
    End Sub
    Private Function GrapthFunctionQuadratic(ByVal NowPosX As Double) As Double

        Dim NowPosY As Double

        'ここが2次関数
        NowPosY = CDbl(TextBox3.Text) * NowPosX ^ 2 + CDbl(TextBox7.Text) * NowPosX + CDbl(TextBox5.Text)

        Return NowPosY
    End Function

    '３次関数
    Private Sub CubicBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CubicBtn.Click
        Call GraphPicture1.DrawGraph(AddressOf GrapthFunctionCubic)
    End Sub
    Private Function GrapthFunctionCubic(ByVal NowPosX As Double) As Double

        Dim NowPosY As Double

        'ここが３次関数
        NowPosY = CDbl(TextBox4.Text) * NowPosX ^ 3 + CDbl(TextBox8.Text) * NowPosX ^ 2 + CDbl(TextBox9.Text) * NowPosX + CDbl(TextBox6.Text)

        Return NowPosY
    End Function

End Class
