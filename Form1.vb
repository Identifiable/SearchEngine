Public Class Form1
    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = TextBox1.Text.Replace(" ", "+")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text.Replace(" ", "+")
        MessageBox.Show("Loading ....")
        Dim link1 As String
        link1 = TextBox1.Text
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/results?search_query=" + link1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = TextBox1.Text.Replace(" ", "+")
        Dim link1 As String
        link1 = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text.Replace(" ", "+")
        Dim link1 As String
        link1 = TextBox1.Text
        Dim oq As String
        oq = "&oq="
        Dim endlink As String
        endlink = "&gs_l=psy-ab.3..0l6j0i10k1j0l3.578.1297.0.1472.4.3.0.0.0.0.87.234.3.3.0....0...1.1.64.psy-ab..1.3.233.0..35i39k1j0i131k1j0i20i263k1.0.xGYYb66ZdV0"
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.google.com/search?safe=strict&source=hp&ei=HWPiWt7fL6SC5wK-54DwCQ&q=" & (link1 + oq + link1) & "&gs_l=psy-ab.3..0l6j0i10k1j0l3.578.1297.0.1472.4.3.0.0.0.0.87.234.3.3.0....0...1.1.64.psy-ab..1.3.233.0..35i39k1j0i131k1j0i20i263k1.0.xGYYb66ZdV0")
    End Sub
End Class
