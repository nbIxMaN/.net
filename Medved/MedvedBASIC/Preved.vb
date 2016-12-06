
Public Class MedvedBASIC
    Inherits MedvedCSHARP.MedvedCSHARP
    Public Overrides Sub MeetMedved()
        System.Console.WriteLine("Preved from VB")
        MyBase.MeetMedved()
    End Sub
End Class
