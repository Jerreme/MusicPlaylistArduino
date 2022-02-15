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
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            'SerialPort1.StopBits = StopBits.None
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.ReadTimeout = 10000

            If (SerialPort1.IsOpen) Then
                SerialPort1.Close()
            Else
                SerialPort1.Open()
                SerialPort1.Close()
            End If
        End If
    End Sub

    Function checkComPort() As Boolean
        Dim detected As String = ""

        For Each names As String In My.Computer.Ports.SerialPortNames
            If (Not names.Equals("")) Then
                detected = names
            End If
        Next

        If (Not detected.Equals("")) Then
            If (Not detected.Equals(comPort)) Then
                comPort = detected
                connectComPort(detected)
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Dim glow As Boolean = False
    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        If (connected) Then
            If (Not glow) Then
                SerialPort1.Open()
                SerialPort1.Write("1")
                SerialPort1.Close()
                glow = True
            Else
                SerialPort1.Open()
                SerialPort1.Write("0")
                SerialPort1.Close()
                glow = False
            End If
        Else
            'Error Message Dialog
        End If
    End Sub

    Private Sub comListener_Tick(sender As Object, e As EventArgs) Handles comListener.Tick
        If (checkComPort()) Then
            connected = True
            comportLabel.Text = comPort
        Else
            connected = False
            comPort = ""
            comportLabel.Text = "Not Connected"
        End If
    End Sub
End Class
