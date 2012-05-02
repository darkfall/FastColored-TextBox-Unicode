Imports System.Drawing.Drawing2D

Public Class BookmarksSample
    ' Key - Line.UniqueId
    Private bookmarksLineId As New Dictionary(Of Integer, Integer)()
    ' Index - bookmark number, Value - Line.UniqueId
    Private bookmarks As New List(Of Integer)()

    Private Sub fctb_LineRemoved(ByVal sender As System.Object, ByVal e As FastColoredTextBoxNS.LineRemovedEventArgs) Handles fctb.LineRemoved
        'remove lines from bookmarks
        For Each id As Integer In e.RemovedLineUniqueIds
            If bookmarksLineId.ContainsKey(id) Then
                bookmarksLineId.Remove(id)
                bookmarks.Remove(id)
            End If
        Next
    End Sub


    Private Sub fctb_PaintLine(ByVal sender As System.Object, ByVal e As FastColoredTextBoxNS.PaintLineEventArgs) Handles fctb.PaintLine
        'draw bookmark
        If bookmarksLineId.ContainsKey(fctb(e.LineIndex).UniqueId) Then
            e.Graphics.FillEllipse(New LinearGradientBrush(New Rectangle(0, e.LineRect.Top, 15, 15), Color.White, Color.PowderBlue, 45), 0, e.LineRect.Top, 15, 15)
            e.Graphics.DrawEllipse(Pens.PowderBlue, 0, e.LineRect.Top, 15, 15)
        End If
    End Sub

    Private Sub GoToBookmark(ByVal iBookmark As Integer)
        If iBookmark < 0 OrElse iBookmark >= bookmarks.Count Then
            Return
        End If

        Dim id As Integer = bookmarks(iBookmark)
        For i As Integer = 0 To fctb.LinesCount - 1
            If fctb(i).UniqueId = id Then
                fctb.Selection.Start = New Place(0, i)
                fctb.DoSelectionVisible()
                fctb.Invalidate()
                Exit For
            End If
        Next
    End Sub

    Private Sub btGo_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGo.DropDownOpening
        btGo.DropDownItems.Clear()
        For i As Integer = 0 To bookmarks.Count - 1
            Dim item = btGo.DropDownItems.Add("Bookmark " & i)
            item.Tag = i
        Next
    End Sub

    Private Sub btRemoveBookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveBookmark.Click
        'get UniqueId of current line
        Dim id As Integer = fctb(fctb.Selection.Start.iLine).UniqueId
        If Not bookmarksLineId.ContainsKey(id) Then
            Return
        End If
        'remove bookmark
        bookmarks.Remove(id)
        bookmarksLineId.Remove(id)
        'repaint
        fctb.Invalidate()
    End Sub

    Private Sub btAddBookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddBookmark.Click
        'get UniqueId of current line
        Dim id As Integer = fctb(fctb.Selection.Start.iLine).UniqueId
        If bookmarksLineId.ContainsKey(id) Then
            Return
        End If
        'add bookmark
        bookmarks.Add(id)
        bookmarksLineId.Add(id, id)
        'repaint
        fctb.Invalidate()
    End Sub

    Private Sub btGo_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btGo.DropDownItemClicked
        GoToBookmark(CInt(e.ClickedItem.Tag))
    End Sub
End Class