Imports SAP2000v1
Imports System.Diagnostics

Public Class FramesFromTextForm

   Protected ParentPluginObject As cPlugin
   Protected SapModel As cSapModel
   Protected ISapPlugin As cPluginCallback
   Private hasLinkProp As Boolean

   Public Sub setParentPluginObject(ByRef inParentPluginObject As cPlugin)

      ParentPluginObject = inParentPluginObject

   End Sub

   Public Sub setSapModel(ByRef inSapModel As cSapModel, ByRef inISapPlugin As cPluginCallback)

      SapModel = inSapModel
      ISapPlugin = inISapPlugin

      TextBox1.Text = "SAP2000 Plugin " & cPlugin.VersionString

      'get link property names
      Dim NumberNames As Integer
      Dim MyNames() As String = Nothing
      Dim ret = SapModel.PropLink.GetNameList(NumberNames, MyNames)
      hasLinkProp = NumberNames > 0
      If Not hasLinkProp Then
         cbxLinkProperties.Items.Add("DEFAULT")
      Else
         For Each n As String In MyNames
            cbxLinkProperties.Items.Add(n)
         Next
      End If
      cbxLinkProperties.SelectedIndex = 0
   End Sub

   Private Sub FramesFromTextForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

      ' It is very important to call ISapPlugin.Finish(0) when form closes, !!!
      ' otherwise, the CSI program will wait and be hung !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

      ISapPlugin.Finish(0)

   End Sub

   Private Sub CreateStructureButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateStructureButton.Click

      Try
         Call CreateStructure(TextBox1.Text)
      Catch ex As Exception
         MsgBox("The following error terminated the Plugin:" & vbCrLf & ex.Message)
      Finally
         Me.Close()
      End Try

   End Sub

   Public Sub CreateStructure(ByRef text As String)

      Dim CallResult As Integer
      Dim i As Integer
      Dim FrameName As String = "FrameName"

      Dim aVectorFont As New cVectorFont
      Dim CharHeight As Double = 200.0
      Dim HAlignment As Integer = cVectorFont.TextAlignment.kTA_HLeft
      Dim VAlignment As Integer = cVectorFont.TextAlignment.kTA_VTop
      Dim textX(1) As Double, textY(1) As Double
      Dim NumPts As Integer

      ' test for exception handling
      If text = "crash" Then
         textX(99) = 0 ' out of bounds
      End If

      aVectorFont.FillTextVertices(text, CharHeight, HAlignment, VAlignment, textX, textY)

      NumPts = textX.Length

      CallResult = SapModel.InitializeNewModel
      CallResult = SapModel.File.NewBlank
      For i = 0 To NumPts - 2
         FrameName = "FrameName" & CStr(i / 2)
         CallResult = SapModel.FrameObj.AddByCoord(textX(i), textY(i), 0, textX(i + 1), textY(i + 1), 0, FrameName)
         i = i + 1
      Next i

      SapModel.View.RefreshView(0, False)

   End Sub

   Private Sub ButtonFrameToLink_Click(sender As Object, e As EventArgs) Handles ButtonFrameToLink.Click

      If cbxLinkProperties.SelectedItem Is Nothing Then
         Return
      End If

      Try
         Call FrameToLink(cbxLinkProperties.SelectedItem.ToString())
      Catch ex As Exception
         MsgBox("The following error terminated the Plugin:" & vbCrLf & ex.Message & ex.StackTrace)
      Finally
         Me.Close()
      End Try


   End Sub

   Public Sub FrameToLink(propLink As String)

      Dim names = GetSelectedName(TypeObj.Frame)

      Dim i = 0
      For Each name As String In names
         i = i + 1
         Dim Point1 As String = Nothing, Point2 As String = Nothing
         SapModel.FrameObj.GetPoints(name, Point1, Point2)
         Console.WriteLine($"Name={name}, Point1={Point1}, Point2={Point2}")
         If hasLinkProp Then
            SapModel.LinkObj.AddByPoint(Point1, Point2, $"Link{i}", PropName:=propLink)
         Else
            SapModel.LinkObj.AddByPoint(Point1, Point2, $"Link{i}")
         End If
         SapModel.FrameObj.Delete(name)
      Next


   End Sub

   Private Function GetSelectedName(typeObj As TypeObj) As List(Of String)
      Dim PtIds As List(Of String) = New List(Of String)

      'dimension variables
      'Dim SapObject As cOAPI
      'Dim SapModel As cSapModel
      Dim ret As Integer
      Dim NumberItems As Integer
      Dim ObjectType() As Integer = Nothing
      Dim ObjectName() As String = Nothing
      Dim tipo As Integer = CInt(typeObj)
      'Debug.WriteLine($"tipo={tipo}")

      'get selected objects
      ret = SapModel.SelectObj.GetSelected(NumberItems, ObjectType, ObjectName)

      'Debug.WriteLine($"NumberItems={NumberItems}")

      'If ObjectType Is Nothing Then
      '   Debug.WriteLine("ObjectType is nothing")
      'End If

      'If ObjectName Is Nothing Then
      '   Debug.WriteLine("ObjectName is nothing")
      'End If

      If ObjectName.Length <> ObjectType.Length Then
         'Debug.WriteLine("ObjectName.Length <> ObjectType.Length")
         'Debug.WriteLine($"ObjectName.Length={ObjectName.Length}")
         'Debug.WriteLine($"ObjectType.Length={ObjectType.Length}")
         Return PtIds
      End If


      ' Type 1 = Point, 2 = Frame, 3 = Cable, 4= Tendon, 5 = Area, 6 = Solid, 7 = Link
      For i As Integer = 0 To ObjectType.Length - 1
         'Debug.WriteLine($"i={i}")
         If (ObjectType(i) = tipo) Then
            'Debug.WriteLine($"adding...")
            PtIds.Add(ObjectName(i))
            'Debug.WriteLine($"added")
         End If
      Next
      'Debug.WriteLine($"done!")
      Return PtIds
   End Function


   Public Enum TypeObj
      None
      Point
      Frame
      Cable
      Tendon
      Area
      Solid
      Link

   End Enum

   Private Sub gr(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub
End Class