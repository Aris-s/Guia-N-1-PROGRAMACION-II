
Module Module1

    Sub Main()
        EJERCICIO1()
        'EJERCICIO2()
        'EJERCICIO3()
        'EJERCICIO4()

        Console.Read()
    End Sub

    Sub EJERCICIO1()

        Try

            Console.Write("Ingrese la distancia en kilómetros: ")
            Dim distanciaKm As Double = Double.Parse(Console.ReadLine())

            Console.Write("Ingrese el tiempo en horas: ")
            Dim horas As Integer = Integer.Parse(Console.ReadLine())

            Console.Write("Ingrese el tiempo en minutos: ")
            Dim minutos As Integer = Integer.Parse(Console.ReadLine())

            Dim tiempoTotalMinutos As Integer = (horas * 60) + minutos

            Dim velocidadKmPorHora As Double = distanciaKm / horas
            Dim velocidadKmPorMinuto As Double = distanciaKm / tiempoTotalMinutos
            Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoTotalMinutos * 60)
            Dim velocidadMPorMinuto As Double = (distanciaKm * 1000) / tiempoTotalMinutos
            Dim velocidadMPorSegundo As Double = (distanciaKm * 1000) / (tiempoTotalMinutos * 60)

            Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora & " Km/h")
            Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto & " Km/min")
            Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo & " Km/s")
            Console.WriteLine("Velocidad media en m/min: " & velocidadMPorMinuto & " m/min")
            Console.WriteLine("Velocidad media en m/s: " & velocidadMPorSegundo & " m/s")
            Console.WriteLine("Estudiante:")
            Console.WriteLine("Damarys Elena Osorio Gutiérrez")
            Console.ReadLine()

        Catch ex As Exception
            Console.WriteLine("SOLO SE DEBEN INGRESAR NÚMEROS")

        End Try

    End Sub

    Sub EJERCICIO2()

        Try
            Console.WriteLine("Ingrese el promedio mensual de infracciones: ")
            Dim promedioMensual As Double = Double.Parse(Console.ReadLine())

            Dim promedioMatutino As Double = (promedioMensual * 0.2) / 30
            Dim promedioTarde As Double = (promedioMensual * 0.35) / 30
            Dim promedioNocturno As Double = (promedioMensual * 0.45) / 30

            Console.WriteLine("Promedio diario de infracciones en la mañana: " & promedioMatutino.ToString())
            Console.WriteLine("Promedio diario de infracciones en la tarde: " & promedioTarde.ToString())
            Console.WriteLine("Promedio diario de infracciones en la noche: " & promedioNocturno.ToString())
            Console.WriteLine("Estudiante:")
            Console.WriteLine("Damarys Elena Osorio Gutiérrez")
            Console.ReadLine()

        Catch ex As Exception
            Console.WriteLine("SOLO SE DEBEN INGRESAR NÚMEROS")

        End Try

    End Sub


    Sub EJERCICIO3()
        Try

            Dim NI As Integer
            Dim N2 As Integer

            Console.Write("Ingrese el primer número: ")
            NI = Convert.ToInt32(Console.ReadLine())

            Console.Write("Ingrese el segundo número: ")
            N2 = Convert.ToInt32(Console.ReadLine())

            If NI Mod N2 = 0 Then
                Console.WriteLine(N2 & " es un divisor de " & NI)
            ElseIf N2 Mod NI = 0 Then
                Console.WriteLine(NI & " es un divisor de " & N2)
            Else
                Console.WriteLine("Ninguno de los números es divisor del otro.")
                Console.WriteLine("Estudiante:")
                Console.WriteLine("Damarys Elena Osorio Gutiérrez")
                Console.ReadLine()
            End If

        Catch ex As Exception
            Console.WriteLine("SOLO SE DEBEN INGRESAR NÚMEROS")

        End Try

    End Sub


    Sub EJERCICIO4()

        Try

            Dim random As New Random

            Dim num1 As Integer = random.Next()
            Dim num2 As Integer = random.Next()
            Dim num3 As Integer = random.Next()

            Console.WriteLine("Ingrese el primer número:")
            num1 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Ingrese el segundo número:")
            num2 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Ingrese el tercer número:")
            num3 = Convert.ToInt32(Console.ReadLine)

            Dim mayor As Integer = Math.Max(num1, Math.Max(num2, num3))
            Dim menor As Integer = Math.Min(num1, Math.Min(num2, num3))
            Dim medio As Integer = (num1 + num2 + num3 - mayor - menor)

            Console.WriteLine("Valores ingresados: {0},{1},{2} ", num1, num2, num3)

            Console.WriteLine("El número mayor es: {0}", mayor)
            Console.WriteLine("El número medio es: {0}", medio)
            Console.WriteLine("El número menor es: {0}", menor)
            Console.WriteLine("Estudiante:")
            Console.WriteLine("Damarys Elena Osorio Gutiérrez")
            Console.ReadLine()

        Catch ex As Exception
            Console.WriteLine("SOLO SE DEBEN INGRESAR NÚMEROS")

        End Try

    End Sub

End Module
