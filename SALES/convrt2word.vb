Module convrt2word

    Public Function GroupToWords(ByVal num As Integer) As _
    String
        Static one_to_nineteen() As String = {"zero", "one",
        "two", "three", "four", "five", "six", "seven",
        "eight", "nine", "ten", "eleven", "twelve",
        "thirteen", "fourteen", "fifteen", "sixteen",
        "seventeen", "eightteen", "nineteen"}
        Static multiples_of_ten() As String = {"twenty",
        "thirty", "forty", "fifty", "sixty", "seventy",
        "eighty", "ninety"}

        ' If the number is 0, return an empty string.
        If num = 0 Then Return ""

        ' Handle the hundreds digit.
        Dim digit As Integer
        Dim result As String = ""
        If num > 99 Then
            digit = num \ 100
            num = num Mod 100
            result = one_to_nineteen(digit) & " hundred"
        End If

        ' If num = 0, we have hundreds only.
        If num = 0 Then Return result.Trim()

        ' See if the rest is less than 20.
        If num < 20 Then
            ' Look up the correct name.
            result &= " " & one_to_nineteen(num)
        Else
            ' Handle the tens digit.
            digit = num \ 10
            num = num Mod 10
            result &= " " & multiples_of_ten(digit - 2)

            ' Handle the final digit.
            If num > 0 Then
                result &= " " & one_to_nineteen(num)
            End If
        End If

        Return result.Trim()
    End Function
    Public Function NumberToString(ByVal num_str As String,
    Optional ByVal use_us_group_names As Boolean = True) As _
    String
        ' Get the appropiate group names.
        Dim groups() As String
        If use_us_group_names Then
            groups = New String() {"", "thousand", "million",
                "billion", "trillion", "quadrillion",
                "quintillion", "sextillion", "septillion",
                "octillion", "nonillion", "decillion",
                "undecillion", "duodecillion", "tredecillion",
                "quattuordecillion", "quindecillion",
                "sexdecillion", "septendecillion",
                "octodecillion", "novemdecillion",
                "vigintillion"}
        Else
            groups = New String() {"", "thousand", "million",
                "milliard", "billion", "1000 billion",
                "trillion", "1000 trillion", "quadrillion",
                "1000 quadrillion", "quintillion", "1000 " &
                "quintillion", "sextillion", "1000 sextillion",
                "septillion", "1000 septillion", "octillion",
                "1000 octillion", "nonillion", "1000 " &
                "nonillion", "decillion", "1000 decillion"}
        End If

        ' Clean the string a bit.
        ' Remove "$", ",", leading zeros, and
        ' anything after a decimal point.
        Const CURRENCY As String = "$"
        Const SEPARATOR As String = ","
        Const DECIMAL_POINT As String = "."
        num_str = num_str.Replace(CURRENCY,
            "").Replace(SEPARATOR, "")
        num_str = num_str.TrimStart(New Char() {"0"c})
        Dim pos As Integer = num_str.IndexOf(DECIMAL_POINT)
        If pos = 0 Then
            Return "zero"
        ElseIf pos > 0 Then
            num_str = num_str.Substring(0, pos - 1)
        End If

        ' See how many groups there will be.
        Dim num_groups As Integer = (num_str.Length + 2) \ 3

        ' Pad so length is a multiple of 3.
        num_str = num_str.PadLeft(num_groups * 3, " "c)

        ' Process the groups, largest first.
        Dim result As String = ""
        Dim group_num As Integer
        For group_num = num_groups - 1 To 0 Step -1
            ' Get the next three digits.
            Dim group_str As String = num_str.Substring(0, 3)
            num_str = num_str.Substring(3)
            Dim group_value As Integer = CInt(group_str)

            ' Convert the group into words.
            If group_value > 0 Then
                If group_num >= groups.Length Then
                    result &= GroupToWords(group_value) &
                        " ?, "
                Else
                    result &= GroupToWords(group_value) &
                        " " & groups(group_num) & ", "
                End If
            End If
        Next group_num

        ' Remove the trailing ", ".
        If result.EndsWith(", ") Then
            result = result.Substring(0, result.Length - 2)
        End If

        Return result.Trim()
    End Function
End Module
