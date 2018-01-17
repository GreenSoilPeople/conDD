Imports System

Module Program

    Private InputFile As String
    Private OutputDir As String
    Private OutputFileBase As String
    Private OutputFileTVA As String

    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        'Console.WriteLine($"arg0:{args(0)} arg1:{args(1)}")


        If ParseArgs(args) <> 0 Then Exit Sub

        Dim lines As String() = IO.File.ReadAllLines(InputFile)




        Console.ReadLine()
    End Sub

    Private Function ParseArgs(args As String()) As Integer
        If args.Count < 2 Then
            Console.WriteLine("Usage: conDD <InputFile> <OutputDir>")
            Return 1
        Else
            InputFile = args(0)
            OutputDir = args(1)
        End If

        If Not IO.File.Exists(InputFile) Then
            Console.WriteLine($"File '{InputFile}' does not exist")
            Return 1
        End If

        Dim InputFileName As String = IO.Path.GetFileName(InputFile)

        Dim m1 = Text.RegularExpressions.Regex.Match(InputFile, "directdebit(\d+)")

        If Not String.IsNullOrWhiteSpace(m1.Value) Then
            Dim day As String
            day = Mid(m1.Groups(1).Value, 7, 2)
            Console.WriteLine($"day: {}")
        End If

        OutputFileBase = $"{OutputDir}\base.csv"


        Return 0
    End Function
End Module
