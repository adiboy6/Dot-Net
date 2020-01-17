Imports System

Module Calculator

    Sub Main()
        Dim number1 As Integer = Integer.Parse(Console.ReadLine())
        Dim number2 As Integer = Integer.Parse(Console.ReadLine())
        
        Console.WriteLine(vbCrLf + "1.Addition" + vbCrLf + "2.Subtraction" + vbCrLf + "3.Multiplication" + vbCrLf + "4.Division (in decimals)")
        
        Console.WriteLine("Choose any one:")
        
        Dim option As Integer = Integer.Parse(Console.ReadLine())
        
        Select Case option
            
            Case 1
                Console.WriteLine("Addition of two numbers:")
                Console.WriteLine(number1+number2)
                
            Case 2
                Console.WriteLine("Subtraction of two numbers:")
                Console.WriteLine(number1-number2)
                
            Case 3
                Console.WriteLine("Multiplication of two numbers:")
                Console.WriteLine(number1*number2)
                
            Case 4
                Console.WriteLine("Division of two numbers:")
                Console.WriteLine(number1/number2)
            
            Case Else
                Console.WriteLine("Wrong option selected")
            
        End Select
        
        Console.ReadKey()

    End Sub
    
End Module