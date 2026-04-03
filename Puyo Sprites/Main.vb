Public Class Main_Form

    Public Add_Number As Long
    Public Add_Number_2 As Long

    Public Offset_Address As UInteger

    Public Word_Byte_1 As Byte
    Public Word_Byte_2 As Byte
    Public Word_Byte_3 As Byte
    Public Word_Byte_4 As Byte
    Public Word_Byte_Full As UShort
    Public Long_Byte_Full As UInteger

    Public Frames_Number As Byte
    Public Offset_Frame(99) As UInteger
    Public Label_Frame(99) As String

    Public Num_Sprites As UShort
    Public Attribute_Section(4) As UShort

    Public Hori_Pos As UShort
    Public Vert_Pos As UShort
    Public Hori_Pos_Neg As UShort
    Public Vert_Pos_Neg As UShort
    Public Hori_Pos_Text As String
    Public Vert_Pos_Text As String

    Public Hori_Size As UShort
    Public Vert_Size As UShort
    Public Link_ID As UShort
    Public Priority As UShort
    Public Pal_ID As UShort
    Public Hori_Rev As UShort
    Public Vert_Rev As UShort
    Public Tile_ID As UShort



    Private Sub File_Open_Click(sender As Object, e As EventArgs) Handles File_Open.Click
        If Open_File.ShowDialog <> DialogResult.Cancel Then ' Opens dialogue box | Exit code if Cancel is pressed
            Try ' Any errors, run error code

                FileOpen(1, Open_File.FileName, OpenMode.Binary, OpenAccess.Read) ' Opens file in Read mode

                Text_Output.Clear()

                Offset_Address = "&H" & ROM_Offset.Text
                Frames_Number = Number_Frames.Text
                Label_Frame(0) = Label_Name.Text

                Text_Output.Text +=
                    Label_Frame(0) & ":" & "    mappingsTable" &
                    vbCrLf & vbCrLf

                Add_Number = 0

                Do
                    Add_Number += 1

                    FileGet(1, Word_Byte_1, Offset_Address + 1)
                    FileGet(1, Word_Byte_2, Offset_Address + 2)
                    FileGet(1, Word_Byte_3, Offset_Address + 3)
                    FileGet(1, Word_Byte_4, Offset_Address + 4)

                    Long_Byte_Full = "&H" &
                    Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_1), 2) &
                    Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_2), 2) &
                    Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_3), 2) &
                    Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_4), 2)

                    Offset_Frame(Add_Number) = Long_Byte_Full
                    Label_Frame(Add_Number) = Label_Name.Text & "_" & Add_Number - 1

                    Text_Output.Text +=
                        vbTab & "mappingsTableEntry.l" & vbTab & Label_Frame(Add_Number) &
                        vbCrLf

                    Offset_Address += 4

                Loop Until Add_Number = Frames_Number

                Text_Output.Text +=
                    vbCrLf &
                    "; ---------------------------------------------------------------------------" &
                    vbCrLf & vbCrLf


                Add_Number = 0
                Add_Number_2 = 0

                Do
                    Add_Number_2 += 1

                    Offset_Address = Offset_Frame(Add_Number_2)

                    FileGet(1, Word_Byte_1, Offset_Address + 1)
                    FileGet(1, Word_Byte_2, Offset_Address + 2)

                    Word_Byte_Full = "&H" &
                    Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_1), 2) &
                    Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_2), 2)

                    Num_Sprites = Word_Byte_Full


                    Text_Output.Text +=
                        Label_Frame(Add_Number_2) & ":" & vbTab & "spriteHeader" & vbCrLf & vbCrLf &
                        vbTab & "; X, Y, Width, Height, Tile, X Flip, Y Flip, Palette, Priority, Link" &
                        vbCrLf & vbCrLf

                    Do
                        Add_Number += 1


                        Offset_Address += 2

                        FileGet(1, Word_Byte_1, Offset_Address + 1)
                        FileGet(1, Word_Byte_2, Offset_Address + 2)

                        Word_Byte_Full = "&H" &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_1), 2) &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_2), 2)

                        Attribute_Section(1) = Word_Byte_Full


                        Offset_Address += 2

                        FileGet(1, Word_Byte_1, Offset_Address + 1)
                        FileGet(1, Word_Byte_2, Offset_Address + 2)

                        Word_Byte_Full = "&H" &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_1), 2) &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_2), 2)

                        Attribute_Section(2) = Word_Byte_Full


                        Offset_Address += 2

                        FileGet(1, Word_Byte_1, Offset_Address + 1)
                        FileGet(1, Word_Byte_2, Offset_Address + 2)

                        Word_Byte_Full = "&H" &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_1), 2) &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_2), 2)

                        Attribute_Section(3) = Word_Byte_Full


                        Offset_Address += 2

                        FileGet(1, Word_Byte_1, Offset_Address + 1)
                        FileGet(1, Word_Byte_2, Offset_Address + 2)

                        Word_Byte_Full = "&H" &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_1), 2) &
                        Microsoft.VisualBasic.Right("00" & Hex(Word_Byte_2), 2)

                        Attribute_Section(4) = Word_Byte_Full


                        Vert_Pos_Neg = Attribute_Section(1) And &B1111111100000000
                        If Vert_Pos_Neg = 0 Then
                            Vert_Pos = Attribute_Section(1)
                            Vert_Pos = Vert_Pos And &B11111111
                            Vert_Pos_Text = Vert_Pos
                        Else
                            Vert_Pos = Attribute_Section(1)
                            Vert_Pos = Vert_Pos And &B11111111
                            Vert_Pos = &HFF - Vert_Pos + 1
                            Vert_Pos_Text = "-" & Vert_Pos
                        End If

                        Hori_Pos_Neg = Attribute_Section(1) And &B1111111100000000
                        If Hori_Pos_Neg = 0 Then
                            Hori_Pos = Attribute_Section(1)
                            Hori_Pos = Hori_Pos And &B11111111
                            Hori_Pos_Text = Hori_Pos
                        Else
                            Hori_Pos = Attribute_Section(1)
                            Hori_Pos = Hori_Pos And &B11111111
                            Hori_Pos = &HFF - Hori_Pos + 1
                            Hori_Pos_Text = "-" & Hori_Pos
                        End If

                        Hori_Size = Attribute_Section(2)
                        Hori_Size = Hori_Size And &B110000000000
                        Hori_Size >>= 10
                        Hori_Size += 1

                        Vert_Size = Attribute_Section(2)
                        Vert_Size = Vert_Size And &B1100000000
                        Vert_Size >>= 8
                        Vert_Size += 1

                        Link_ID = Attribute_Section(2)
                        Link_ID = Link_ID And &B1111111

                        Priority = Attribute_Section(3)
                        Priority = Priority And &B1000000000000000
                        Priority >>= 15

                        Pal_ID = Attribute_Section(3)
                        Pal_ID = Pal_ID And &B110000000000000
                        Pal_ID >>= 13

                        Hori_Rev = Attribute_Section(3)
                        Hori_Rev = Hori_Rev And &B100000000000
                        Hori_Rev >>= 11

                        Vert_Rev = Attribute_Section(3)
                        Vert_Rev = Vert_Rev And &B1000000000000
                        Vert_Rev >>= 12

                        Tile_ID = Attribute_Section(3)
                        Tile_ID = Tile_ID And &B11111111111


                        Text_Output.Text +=
                            vbTab & "spritePiece " &
                            Hori_Pos_Text & ", " &
                            Vert_Pos_Text & ", " &
                            Hori_Size & ", " &
                            Vert_Size & ", " &
                            "$" & Hex(Tile_ID) & ", " &
                            Hori_Rev & ", " &
                            Vert_Rev & ", " &
                            Pal_ID & ", " &
                            Priority & ", " &
                            Link_ID &
                            vbCrLf

                    Loop Until Add_Number = Num_Sprites

                    Text_Output.Text +=
                    vbCrLf &
                    Label_Frame(Add_Number_2) & "_End" &
                    vbCrLf & vbCrLf &
                    "; ---------------------------------------------------------------------------" &
                    vbCrLf & vbCrLf

                    Add_Number = 0

                Loop Until Add_Number_2 = Frames_Number

                Text_Output.Text +=
                    vbTab & "even"

                FileClose(1)  ' Close the file

                Save_Text_Dialog.FileName = Label_Name.Text

            Catch ex As Exception ' If an error occured (wrong file / file opened)
                FileClose(1)  ' Close the file
                Application.Exit() ' Close the tool
            End Try
        End If
    End Sub

    Private Sub About_Tool_Click(sender As Object, e As EventArgs) Handles About_Tool.Click

        MessageBox.Show("Puyo Puyo 1 / Mean Bean Machine - Extract Sprite Mappings (V1.1)" & vbNewLine & "by RadioTails", "About")

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If (Save_Text_Dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (Save_Text_Dialog.FileName.Length) > 0 Then

            ' Save the contents of the RichTextBox into the file.
            Text_Output.SaveFile(Save_Text_Dialog.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub
End Class
