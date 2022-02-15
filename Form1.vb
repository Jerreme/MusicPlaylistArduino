Imports System.IO.Ports

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


    End Sub

    Dim comPort As String = ""
    Dim connected As Boolean = False

    Sub connectComPort(comName As String)
        If (comName <> "") Then
            SerialPort1.PortName = comName
            SerialPort1.BaudRate = 9600

            'Comment ko na to dinapala to need mga to
            'SerialPort1.DataBits = 8
            'SerialPort1.Parity = Parity.None
            'SerialPort1.StopBits = StopBits.None
            'SerialPort1.Handshake = Handshake.None
            'SerialPort1.Encoding = System.Text.Encoding.Default
            'SerialPort1.ReadTimeout = 10000


            If (SerialPort1.IsOpen) Then 'if com is open then close it
                SerialPort1.Close()
            Else 'if com is close the open it then close
                'this re-established the connection
                SerialPort1.Open()
                SerialPort1.Close()
            End If
        End If
    End Sub

    Function checkComPort() As Boolean
        Dim detected As String = ""

        For Each names As String In My.Computer.Ports.SerialPortNames
            If (Not names.Equals("")) Then
                'find com
                detected = names
            End If
        Next

        If (Not detected.Equals("")) Then
            If (Not detected.Equals(comPort)) Then
                comPort = detected
                'if comport has changed connect again
                connectComPort(detected)
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Dim glow As Boolean = False

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Try
            If (connected) Then

                If Label1.Text = title1.Text Then
                    SerialPort1.Open()
                    SerialPort1.Write("1")
                    SerialPort1.Close()

                ElseIf Label1.Text = title2.Text Then
                    SerialPort1.Open()
                    SerialPort1.Write("2")
                    SerialPort1.Close()
                ElseIf Label1.Text = title3.Text Then
                    SerialPort1.Open()
                    SerialPort1.Write("3")
                    SerialPort1.Close()


                Else
                    SerialPort1.Open()
                    SerialPort1.Write("0/")
                    SerialPort1.Close()

                End If
                play.Show()
                btnStop.Hide()
            End If
        Catch ex As Exception
            MsgBox("Dont know" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function Label2_Click() As Boolean
        Throw New NotImplementedException()
    End Function

    Private Sub comListener_Tick(sender As Object, e As EventArgs) Handles comListener.Tick
        'This is the listener to our port 
        'This loops every 200ms 

        If (checkComPort()) Then
            connected = True
            comportLabel.Text = comPort
        Else
            connected = False
            comPort = ""
            comportLabel.Text = "Not Connected"
        End If
    End Sub

    Private Sub comportLabel_Click(sender As Object, e As EventArgs) Handles comportLabel.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles title1.Click
        Label1.Text = title1.Text
        artist.Text = artist1.Text
        SerialPort1.Open()
        SerialPort1.Write("1/")
        SerialPort1.Close()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If Label1.Text = title1.Text Then
            SerialPort1.Write("2/")
        ElseIf Label1.Text = title2.Text Then
            SerialPort1.Write("3/")
        ElseIf Label1.Text = title3.Text Then
            SerialPort1.Write("1/")


        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If Label1.Text = title1.Text Then
            SerialPort1.Write("3/")
        ElseIf Label1.Text = title3.Text Then
            SerialPort1.Write("2/")
        ElseIf Label1.Text = title2.Text Then
            SerialPort1.Write("1/")

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub title2_Click(sender As Object, e As EventArgs) Handles title2.Click
        Label1.Text = title2.Text
        artist.Text = artist2.Text
        SerialPort1.Open()
        SerialPort1.Write("2/")
        SerialPort1.Close()

    End Sub

    Private Sub title3_Click(sender As Object, e As EventArgs) Handles title3.Click
        Label1.Text = title3.Text
        artist.Text = artist3.Text
        SerialPort1.Open()
        SerialPort1.Write("3/")
        SerialPort1.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles artist1.Click

        Label1.Text = title1.Text
        artist.Text = artist1.Text
    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint
        Label1.Text = title1.Text
        artist.Text = artist1.Text
    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint
        Label1.Text = title2.Text
        artist.Text = artist2.Text
    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint
        Label1.Text = title3.Text
        artist.Text = artist3.Text
    End Sub

    Private Sub artist3_Click(sender As Object, e As EventArgs) Handles artist3.Click
        Label1.Text = title3.Text
        artist.Text = artist3.Text
    End Sub

    Private Sub artist2_Click(sender As Object, e As EventArgs) Handles artist2.Click
        Label1.Text = title2.Text
        artist.Text = artist2.Text
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles play.Click
        play.Hide()
        btnStop.Show()

    End Sub
End Class
