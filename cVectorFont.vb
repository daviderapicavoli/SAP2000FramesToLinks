Public Class cVectorFont
    Public Enum TextAlignment
        kTA_HLeft = 0
        kTA_HCenter
        kTA_HRight
        kTA_VBottom
        kTA_VCenter
        kTA_VTop
    End Enum

    Protected Const VF_CHARACTERS As Integer = 96
    Protected Const VF_MOVES_PER_CHARACTER As Integer = 20
    Protected Const VF_ASPECT_RATIO As Double = 0.5

    Structure VFData
        Dim XI As Double
        Dim YI As Double
        Dim pen As Integer
    End Structure

    'std::vector<std::vector<VFData> > vf;
    Protected vf(,) As VFData

    Public Sub New()
        ReDim vf(VF_CHARACTERS + 1, VF_CHARACTERS + 1)

        Initialize()
    End Sub

    Protected Sub Initialize()
        Dim VectorChar(97) As String, tmpString As String
        Dim i As Integer, j As Integer, k As Integer
        VectorChar(1) = "923 000"
        VectorChar(2) = "323 422 343 442 462 572 482 382 272 362 342 923 000"
        VectorChar(3) = "383 272 262 162 172 272 683 572 562 462 472 572 923 000"
        VectorChar(4) = "133 172 573 532 643 042 063 662 923 000"
        VectorChar(5) = "133 532 642 552 152 062 172 572 383 322 923 000"
        VectorChar(6) = "163 262 372 282 182 072 162 573 132 423 522 632 542 442 332 422 923 000"
        VectorChar(7) = "623 172 282 482 472 052 032 122 422 532 632 923 000"
        VectorChar(8) = "483 372 362 262 272 372 923 000"
        VectorChar(9) = "683 472 252 232 412 602 923 000"
        VectorChar(10) = "283 472 652 632 412 203 923 000"
        VectorChar(11) = "333 372 563 142 053 652 543 162 923 000"
        VectorChar(12) = "333 372 053 652 923 000"
        VectorChar(13) = "213 322 332 232 222 322 923 000"
        VectorChar(14) = "053 652 923 000"
        VectorChar(15) = "223 322 332 232 222 923 000"
        VectorChar(16) = "682 923 000"
        VectorChar(17) = "123 522 632 672 582 182 072 032 122 133 572 923 000"
        VectorChar(18) = "323 522 423 482 372 923 000"
        VectorChar(19) = "173 282 582 672 662 032 022 622 923 000"
        VectorChar(20) = "033 122 522 632 642 552 352 553 662 672 582 282 172 923 000"
        VectorChar(21) = "423 622 523 582 042 642 923 000"
        VectorChar(22) = "033 122 522 632 642 552 152 182 582 923 000"
        VectorChar(23) = "583 262 152 042 032 122 522 632 642 552 152 923 000"
        VectorChar(24) = "023 682 182 072 923 000"
        VectorChar(25) = "123 522 632 642 452 252 162 172 282 482 572 562 452 253 042 032 122 923 000"
        VectorChar(26) = "023 442 662 672 582 182 072 062 152 552 923 000"
        VectorChar(27) = "223 322 332 232 222 253 352 362 262 252 923 000"
        VectorChar(28) = "213 322 332 232 222 322 253 352 362 262 252 923 000"
        VectorChar(29) = "533 152 572 923 000"
        VectorChar(30) = "143 542 563 162 923 000"
        VectorChar(31) = "043 452 062 352 042 923 000"
        VectorChar(32) = "223 322 243 342 352 562 572 482 182 072 923 000"
        VectorChar(33) = "553 542 342 352 552 662 572 272 062 032 222 522 632 923 000"
        VectorChar(34) = "052 382 652 622 043 642 923 000"
        VectorChar(35) = "082 482 572 562 452 552 642 632 522 022 053 452 923 000"
        VectorChar(36) = "573 482 182 072 032 122 522 632 923 000"
        VectorChar(37) = "082 582 672 632 522 022 923 000"
        VectorChar(38) = "082 582 353 052 023 622 923 000"
        VectorChar(39) = "082 682 453 052 923 000"
        VectorChar(40) = "353 552 642 632 522 122 032 072 182 482 572 923 000"
        VectorChar(41) = "082 053 652 683 622 923 000"
        VectorChar(42) = "123 522 323 382 183 582 923 000"
        VectorChar(43) = "033 122 422 532 582 383 682 923 000"
        VectorChar(44) = "082 053 352 683 352 622 923 000"
        VectorChar(45) = "083 022 622 923 000"
        VectorChar(46) = "082 352 682 622 923 000"
        VectorChar(47) = "082 622 682 582 923 000"
        VectorChar(48) = "033 072 182 582 672 632 522 122 032 923 000"
        VectorChar(49) = "082 582 672 662 552 052 923 000"
        VectorChar(50) = "033 072 182 582 672 632 522 122 032 343 432 622 923 000"
        VectorChar(51) = "082 582 672 662 552 052 453 442 622 923 000"
        VectorChar(52) = "033 122 522 632 642 552 152 062 072 182 482 572 923 000"
        VectorChar(53) = "323 382 083 682 923 000"
        VectorChar(54) = "083 032 122 522 632 682 923 000"
        VectorChar(55) = "083 052 322 652 682 923 000"
        VectorChar(56) = "083 022 352 622 682 923 000"
        VectorChar(57) = "682 083 622 923 000"
        VectorChar(58) = "323 352 082 683 352 923 000"
        VectorChar(59) = "083 682 022 622 253 452 923 000"
        VectorChar(60) = "423 222 282 482 923 000"
        VectorChar(61) = "083 622 923 000"
        VectorChar(62) = "223 422 482 282 923 000"
        VectorChar(63) = "153 372 552 923 000"
        VectorChar(64) = "013 612 923 000"
        VectorChar(65) = "453 362 372 272 262 362 923 000"
        VectorChar(66) = "623 532 422 122 032 042 152 452 542 652 543 532 923 000"
        VectorChar(67) = "072 043 252 552 642 632 522 122 032 923 000"
        VectorChar(68) = "553 152 042 032 122 522 632 923 000"
        VectorChar(69) = "623 672 643 452 152 042 032 122 522 632 923 000"
        VectorChar(70) = "623 122 032 042 262 462 642 042 923 000"
        VectorChar(71) = "223 262 372 472 562 143 342 923 000"
        VectorChar(72) = "103 402 512 542 652 543 452 152 042 032 122 422 532 923 000"
        VectorChar(73) = "072 043 252 552 642 622 923 000"
        VectorChar(74) = "373 472 353 322 422 923 000"
        VectorChar(75) = "373 472 453 402 202 923 000"
        VectorChar(76) = "072 043 442 552 443 622 923 000"
        VectorChar(77) = "273 222 422 923 000"
        VectorChar(78) = "052 152 332 552 652 622 923 000"
        VectorChar(79) = "052 043 252 552 642 622 923 000"
        VectorChar(80) = "123 032 042 152 552 642 632 522 122 923 000"
        VectorChar(81) = "002 023 052 043 252 552 642 632 522 222 032 923 000"
        VectorChar(82) = "653 642 452 152 042 032 122 522 632 643 602 702 923 000"
        VectorChar(83) = "052 043 252 552 642 923 000"
        VectorChar(84) = "522 632 542 242 152 362 562 923 000"
        VectorChar(85) = "423 322 372 263 562 923 000"
        VectorChar(86) = "053 032 122 422 522 552 533 622 923 000"
        VectorChar(87) = "053 222 552 652 923 000"
        VectorChar(88) = "052 023 122 342 522 622 652 923 000"
        VectorChar(89) = "122 342 552 652 053 152 342 522 622 923 000"
        VectorChar(90) = "053 032 122 422 632 652 633 602 402 923 000"
        VectorChar(91) = "652 052 023 622 923 000"
        VectorChar(92) = "483 372 362 252 342 332 422 923 000"
        VectorChar(93) = "323 342 363 382 923 000"
        VectorChar(94) = "223 332 342 452 362 372 282 923 000"
        VectorChar(95) = "073 182 282 462 562 672 923 000"
        VectorChar(96) = "123 152 052 382 652 552 522 122 923 000"
        For i = 1 To VF_CHARACTERS
            For j = 1 To VF_MOVES_PER_CHARACTER
                k = (4 * j) - 4 'k = (4 * j) - 3;
                tmpString = VectorChar(i).Substring(k + 2, 1)
                vf(i, j).pen = Integer.Parse(tmpString)
                If vf(i, j).pen = 0 Then Exit For
                tmpString = VectorChar(i).Substring(k, 1)
                vf(i, j).XI = Double.Parse(tmpString)
                vf(i, j).XI *= VF_ASPECT_RATIO
                tmpString = VectorChar(i).Substring(k + 1, 1)
                vf(i, j).YI = Double.Parse(tmpString)
            Next j
        Next i

    End Sub

    Public Sub FillTextVertices(ByVal inStr As String, ByVal CharHeight As Double, ByVal HAlignment As Integer, ByVal VAlignment As Integer, ByRef tX() As Double, ByRef tY() As Double)

        Dim i, j, NumChars, NumPts, pos As Integer
        Const CharWidth As Double = VF_ASPECT_RATIO * 9 ' 9 is initial height

        NumPts = 0
        NumChars = inStr.Length()

        For pos = 0 To NumChars - 1
            If Microsoft.VisualBasic.Asc(inStr.Substring(pos, 1)) = 13 Then
                'do nothing
            ElseIf Microsoft.VisualBasic.Asc(inStr.Substring(pos, 1)) = 10 Then
                'do nothing
            Else
                i = Microsoft.VisualBasic.Asc(inStr.Substring(pos, 1)) - 31
                For j = 1 To VF_MOVES_PER_CHARACTER
                    If vf(i, j).pen = 2 Then NumPts += 2
                Next j
            End If
        Next pos

        ReDim tX(NumPts)
        ReDim tY(NumPts)

        Dim LineStart As Integer = 0, LineEnd As Integer = 1
        Dim YOffset As Double = 0.0
        Dim CharStartX As Double = 0.0
        Dim XCurrent As Double = 0.0
        Dim YCurrent As Double = 0.0
        Dim XStart As Double, YStart As Double

        For pos = 0 To NumChars - 1
            If Microsoft.VisualBasic.Asc(inStr.Substring(pos, 1)) = 13 Then
                YOffset -= 9.0 + 2.0 '9.0 is initial char height, 2.0 is spacing
                CharStartX = 0.0
            ElseIf Microsoft.VisualBasic.Asc(inStr.Substring(pos, 1)) = 10 Then
                'do nothing
            Else
                i = Microsoft.VisualBasic.Asc(inStr.Substring(pos, 1)) - 31 ' ASCII 32 is VectorFont(1)   

                If vf(i, 1).pen = 2 Then
                    XStart = CharStartX
                    YStart = 2.0 + YOffset
                End If

                For j = 1 To VF_MOVES_PER_CHARACTER

                    If vf(i, j).pen = 0 Then Exit For

                    If vf(i, j).pen = 2 Then ' pen down finishes a line
                        XCurrent = vf(i, j).XI + CharStartX
                        YCurrent = vf(i, j).YI + YOffset

                        tX(LineStart) = XStart : tX(LineEnd) = XCurrent
                        tY(LineStart) = YStart : tY(LineEnd) = YCurrent

                        LineStart += 2 : LineEnd += 2

                        XStart = XCurrent
                        YStart = YCurrent
                    ElseIf vf(i, j).pen = 3 Then ' pen up starts a new line
                        XStart = vf(i, j).XI + CharStartX
                        YStart = vf(i, j).YI + YOffset
                    End If
                Next j
                CharStartX += CharWidth
            End If
        Next pos

        Dim ScaleFactor As Double = CharHeight / 9.0
        Dim OffsetX As Double = 0.0, OffsetY = 0.0

        Select Case HAlignment
            Case TextAlignment.kTA_HCenter
                OffsetX = -NumChars * CharWidth / 2.0
            Case TextAlignment.kTA_HRight
                OffsetX = -NumChars * CharWidth
        End Select

        Select Case VAlignment
            Case TextAlignment.kTA_VCenter
                OffsetY = -9 / 2.0
            Case TextAlignment.kTA_VTop
                OffsetY = 0.0
            Case TextAlignment.kTA_VBottom
                OffsetY = -9.0
        End Select

        For i = 0 To NumPts - 1
            tX(i) += OffsetX : tY(i) += OffsetY
            tX(i) *= ScaleFactor : tY(i) *= ScaleFactor
        Next i

    End Sub

End Class
