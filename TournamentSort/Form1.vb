Public Class Form1

    ' Estructura para representar a cada país competidor
    Public Structure Pais
        Public Nombre As String
        Public Poblacion As Integer

        Public Sub New(nombre As String, poblacion As Integer)
            Me.Nombre = nombre
            Me.Poblacion = poblacion
        End Sub

        Public Overrides Function ToString() As String
            Return $"{Nombre} ({Poblacion.ToString("N0")} hab.)"
        End Function
    End Structure

    Private participantes() As Pais

    ' Método para cargar la lista inicial de países participantes
    Private Sub btnGenerateData_Click(sender As Object, e As EventArgs) Handles btnGenerateData.Click
        lstCountries.Items.Clear()
        tvTournament.Nodes.Clear()
        lstLogs.Clear()

        lstLogs.AppendText("[SISTEMA] Cargando base de datos de países..." & vbCrLf)

        participantes = New Pais() {
            New Pais("Perú", 34000000),
            New Pais("Japón", 125000000),
            New Pais("Canadá", 38000000),
            New Pais("Egipto", 109000000),
            New Pais("Brasil", 214000000),
            New Pais("Italia", 59000000),
            New Pais("Australia", 25000000),
            New Pais("India", 1400000000)
        }

        For Each p As Pais In participantes
            lstCountries.Items.Add(p)
        Next

        lstLogs.AppendText("[SISTEMA] ¡8 países registrados y listos para competir!" & vbCrLf)
    End Sub

    ' Valida e inicia la ejecución del torneo
    Private Sub btnStartTournament_Click(sender As Object, e As EventArgs) Handles btnStartTournament.Click
        If participantes Is Nothing OrElse participantes.Length = 0 Then
            MessageBox.Show("¡Primero debes cargar los países!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        lstLogs.Clear()
        tvTournament.Nodes.Clear()
        lstLogs.AppendText("====================================" & vbCrLf)
        lstLogs.AppendText("🏆 INICIA EL TOURNAMENT SORT 🏆" & vbCrLf)
        lstLogs.AppendText("====================================" & vbCrLf)

        EjecutarTournamentSort(participantes)
    End Sub

    ' Aquí se maneja la lógica de recorrido para el ranking de países
    Private Sub EjecutarTournamentSort(arregloOriginal() As Pais)
        Dim competidores As New List(Of Pais)(arregloOriginal)
        Dim listaOrdenada As New List(Of Pais)
        Dim nodoRaiz As New TreeNode("🏆 TORNEO MUNDIAL 🏆")
        tvTournament.Nodes.Add(nodoRaiz)

        Dim ronda As Integer = 1

        While competidores.Count > 0
            Dim nodoRonda As TreeNode = Nothing

            If ronda = 1 Then
                lstLogs.AppendText(vbCrLf & "--- 🎬 GRAN TORNEO: BUSCANDO AL CAMPEÓN ---" & vbCrLf)
                nodoRonda = New TreeNode("Llaves para el 1er Puesto")
                nodoRaiz.Nodes.Add(nodoRonda)
            End If

            Dim narrarPartidos As Boolean = (ronda = 1)
            Dim ganadorActual As Pais = TorneoRecursivo(competidores, nodoRonda, narrarPartidos)

            ' Gestión visual del podio y ranking final
            If ronda = 1 Then
                lstLogs.AppendText(vbCrLf & $"🥇 CAMPEÓN (1er Puesto): {ganadorActual.Nombre}!" & vbCrLf)
                lstLogs.AppendText("--- CALCULANDO RESTO DEL RANKING... ---" & vbCrLf)
            ElseIf ronda = 2 Then
                lstLogs.AppendText($"🥈 2do Puesto: {ganadorActual.Nombre}" & vbCrLf)
            ElseIf ronda = 3 Then
                lstLogs.AppendText($"🥉 3er Puesto: {ganadorActual.Nombre}" & vbCrLf)
            Else
                lstLogs.AppendText($"🏅 {ronda}to Puesto: {ganadorActual.Nombre}" & vbCrLf)
            End If

            listaOrdenada.Add(ganadorActual)
            competidores.Remove(ganadorActual)
            ronda += 1
        End While

        lstLogs.AppendText("====================================" & vbCrLf)
        lstLogs.AppendText("✅ ORDENAMIENTO COMPLETADO ✅" & vbCrLf)

        tvTournament.ExpandAll()
        lstCountries.Items.Clear()
        lstCountries.Items.Add("--- RANKING FINAL ---")
        For Each p As Pais In listaOrdenada
            lstCountries.Items.Add(p)
        Next
    End Sub

    ' Lógica recursiva para los enfrentamientos por llaves
    Private Function TorneoRecursivo(listaActual As List(Of Pais), nodoPadre As TreeNode, narrar As Boolean) As Pais
        If listaActual.Count = 1 Then
            Return listaActual(0)
        End If

        Dim ganadoresSiguienteRonda As New List(Of Pais)

        For i As Integer = 0 To listaActual.Count - 1 Step 2
            If i + 1 >= listaActual.Count Then
                Dim avanzaSolo As Pais = listaActual(i)
                If narrar Then lstLogs.AppendText($"  [Pase Directo] {avanzaSolo.Nombre} avanza sin rival." & vbCrLf)
                If nodoPadre IsNot Nothing Then nodoPadre.Nodes.Add($"Pase Directo: {avanzaSolo.Nombre}")
                ganadoresSiguienteRonda.Add(avanzaSolo)
            Else
                Dim pais1 As Pais = listaActual(i)
                Dim pais2 As Pais = listaActual(i + 1)
                Dim ganadorPartido As Pais

                ' Comparación por población para determinar el ganador
                If pais1.Poblacion >= pais2.Poblacion Then
                    ganadorPartido = pais1
                Else
                    ganadorPartido = pais2
                End If

                If narrar Then
                    lstLogs.AppendText($"  ⚔️ {pais1.Nombre} vs {pais2.Nombre} --> Gana: {ganadorPartido.Nombre}" & vbCrLf)
                End If

                If nodoPadre IsNot Nothing Then
                    Dim nodoPartido As New TreeNode($"{pais1.Nombre} vs {pais2.Nombre} => Avanza {ganadorPartido.Nombre}")
                    nodoPadre.Nodes.Add(nodoPartido)
                End If

                ganadoresSiguienteRonda.Add(ganadorPartido)
            End If
        Next

        Return TorneoRecursivo(ganadoresSiguienteRonda, nodoPadre, narrar)
    End Function

    ' Configuración de la interfaz y elementos institucionales
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        Try
            lstLogs.Multiline = True
            lstLogs.WordWrap = True
            lstLogs.ScrollBars = ScrollBars.Vertical

            Dim webClient As New System.Net.WebClient()
            Dim iconData As Byte() = webClient.DownloadData("https://uprit.edu.pe/favicon/apple-touch-icon.png")
            Using ms As New System.IO.MemoryStream(iconData)
                Me.Icon = New System.Drawing.Icon(ms)
            End Using
        Catch ex As Exception
            Me.Text = "🏆 TOURNAMENT SORT - UPRIT 🏆"
        End Try
    End Sub

    Private Sub lblGroup_Click(sender As Object, e As EventArgs) Handles lblGroup.Click
        ' Evento de etiqueta de grupo
    End Sub

End Class