Imports System.ComponentModel

Public Class frmSplash

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        Me.Close()
        'Se cierra el form cuando el timer culmina su intervalo
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSplash.Start()
        'Inicia timer cuando el Form Splash es iniciado
    End Sub
End Class