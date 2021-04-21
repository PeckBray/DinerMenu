'Brayden Peck
'RCET 0265
'Spring 2021
'Diner Menu Program
'
Option Strict On
Option Explicit On
Public Class DinerMenuForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = $"~Soup of the Day~{vbNewLine}{vbNewLine}Fresh shredded chicken, chopped carrots and celery with egg noodle is a hearty broth. Served with Saltine crackers."
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = $"~Classic Ceaser Salad~{vbNewLine}{vbNewLine}Crisp Hearts of Romaine Tossed in Robust Caesar Dressing {vbNewLine} Topped with Herbed Croutons and Parmesan Cheese"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = $"~Fresh Fried Cod~{vbNewLine}{vbNewLine}Freshly caught Cod, fried to perfection. Served with freshly cut Potato Fries."
    End Sub
End Class
