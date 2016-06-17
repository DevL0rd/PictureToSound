Imports System.Threading
Imports System.IO
Imports System.Media
Public Class Form1
    'Private Declare Function Beep Lib "kernel32" (ByVal soundFrequency As Int32, ByVal soundDuration As Int32) As Int32
    Public playthread As New Thread(AddressOf PlayPicture)
    Public playing As Boolean = False
    Public stopplaying As Boolean = False
    Public AudioSync As New Object
    Public py As Integer = 0
    Public px As Integer = 0
    Public filepath As String = ""
    Dim lines() As String = IO.File.ReadAllLines("words.txt")
    Dim backgroundsynctoggle As Boolean = True
    Dim textsynctoggle As Boolean = True
    Private Function GetColor(pic As PictureBox, X As Integer, Y As Integer) As Color

        If pic Is Nothing Then Return Nothing

        Using tmp As New Bitmap(pic.ClientSize.Width, pic.ClientSize.Height)

            Dim r As New Rectangle(0, 0, tmp.Width, tmp.Height)

            Using g As Graphics = Graphics.FromImage(tmp)
                g.DrawImage(pic.Image, r, r, GraphicsUnit.Pixel)
            End Using

            Return tmp.GetPixel(X, Y)

        End Using

    End Function

    Function PlayPicture()
        Output.Clear()
        If filepath IsNot "" Then
            PictureBox1.Image = Image.FromFile(filepath)
            stopplaying = False
            playing = True
            PlayButton.Visible = False
            'Declare py,px as pixel positions
            Dim pt As New Point(0, 0)
            Dim g As Graphics
            Dim red As Integer = 0
            Dim green As Integer = 0
            Dim blue As Integer = 0
            Dim pixel As Color
            Dim freq As Integer = 0
            Dim textselect As Integer = 0
            'Loop through each row of pixels in Picturebox1...
            For py = 0 To PictureBox1.Image.Height - 1
                For px = 0 To PictureBox1.Image.Width - 1
                    pixel = GetColor(PictureBox1, px, py)
                    red = pixel.R
                    green = pixel.G
                    blue = pixel.B
                    freq = (red + green + blue) * Frequency_Modifier.Value
                    textselect = red & green & blue
                    While textselect > 354985
                        If textselect > 354985 Then
                            textselect = textselect / 3
                        End If
                    End While
                    Output.Text = Output.Text & " " & lines(textselect)
                    While freq > 4500 Or freq < 200
                        If freq = 0 Then
                            freq = 201
                        ElseIf freq > 4500 Then
                            freq = freq / 3
                        ElseIf freq < 200 Then
                            freq = freq * 3
                        End If
                    End While
                    Beep(1000, freq, Speed_Modifier.Value)
                    g = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(Brushes.Green, px, py, 1, 1)
                    PictureBox1.Invalidate()
                    g.Dispose()
                    If backgroundsynctoggle Then
                        BackColor = pixel
                    End If
                    If textsynctoggle Then
                        SpeedLabel.ForeColor = pixel
                        FreqModLabel.ForeColor = pixel
                        MenuFile.ForeColor = pixel
                        MenuView.ForeColor = pixel
                        BackgroundSync.ForeColor = pixel
                        OpenToolStripMenuItem.ForeColor = pixel
                        TextColorSync.ForeColor = pixel
                    End If
                    PlayButton.BackColor = pixel
                    Application.DoEvents()
                    If stopplaying = True Then
                        Exit For
                    End If
                    While playing = False
                        Application.DoEvents()
                    End While
                Next
                If stopplaying = True Then
                    Exit For
                End If
                While playing = False
                    Application.DoEvents()
                End While
            Next
            stopplaying = False
        End If
        Return 0
    End Function
    Private Sub Frequency_Modifier_Scroll(sender As Object, e As EventArgs) Handles Frequency_Modifier.Scroll
        FreqModLabel.Text = "Frequency Modifier (" & Frequency_Modifier.Value & ")"
    End Sub

    Private Sub Speed_Modifier_Scroll(sender As Object, e As EventArgs) Handles Speed_Modifier.Scroll
        SpeedLabel.Text = "Speed Modifier (" & Speed_Modifier.Value & ")"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        stopplaying = True
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String
        fd.Title = "Choose Image To Listen Too"
        fd.Filter = "All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        PictureBox1.ImageLocation = filepath
        playing = False
        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            filepath = fd.FileName
            PictureBox1.Image = Image.FromFile(filepath)
            PlayPicture()
        End If
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If playing = False Then
            playing = True
            PlayPicture()
        End If
    End Sub
    Sub Beep(ByVal Amplitude As Integer,
             ByVal Frequency As Integer,
             ByVal Duration As Integer)
        Dim A As Double = ((Amplitude * 2 ^ 15) / 1000) - 1
        Dim DeltaFT As Double = 2 * Math.PI * Frequency / 44100

        Dim Samples As Integer = 441 * Duration \ 10
        Dim Bytes As Integer = Samples * 4
        Dim Hdr() As Integer = {&H46464952, 36 + Bytes, &H45564157,
                                &H20746D66, 16, &H20001, 44100,
                                 176400, &H100004, &H61746164, Bytes}
        Using MS As New MemoryStream(44 + Bytes)
            Using BW As New BinaryWriter(MS)
                For I As Integer = 0 To Hdr.Length - 1
                    BW.Write(Hdr(I))
                Next
                For T As Integer = 0 To Samples - 1
                    Dim Sample As Short = CShort(A * Math.Sin(DeltaFT * T))
                    BW.Write(Sample)
                    BW.Write(Sample)
                Next
                BW.Flush()
                MS.Seek(0, SeekOrigin.Begin)
                Using SP As New SoundPlayer(MS)
                    SP.PlaySync()
                End Using
            End Using
        End Using
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PlayButton.Text = "▶"
        PlayButton.Visible = True
        playing = False
        stopplaying = True
    End Sub

    Private Sub BackgroundSync_Click(sender As Object, e As EventArgs) Handles BackgroundSync.Click
        If backgroundsynctoggle Then
            BackgroundSync.Text = "Background Color Sync (OFF)"
            backgroundsynctoggle = False
            BackColor = SystemColors.ControlDarkDark
        Else
            BackgroundSync.Text = "Background Color Sync (ON)"
            backgroundsynctoggle = True
        End If
    End Sub

    Private Sub TextColorSync_Click(sender As Object, e As EventArgs) Handles TextColorSync.Click
        If textsynctoggle Then
            SpeedLabel.ForeColor = Color.White
            FreqModLabel.ForeColor = Color.White
            MenuFile.ForeColor = Color.White
            MenuView.ForeColor = Color.White
            BackgroundSync.ForeColor = Color.White
            OpenToolStripMenuItem.ForeColor = Color.White
            TextColorSync.ForeColor = Color.White
            TextColorSync.Text = "Text Color Sync (OFF)"
            textsynctoggle = False
            BackColor = SystemColors.ControlDarkDark
        Else
            TextColorSync.Text = "Text Color Sync (ON)"
            textsynctoggle = True
        End If
    End Sub
End Class