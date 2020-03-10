# penknife
Little multitool written in C#

List of commands:<br>

help  /  h<br>
      Help Menu<br>

length [string]<br>
      Returns the length of a string. To count something longer than a
      word, concatinate the text in quotation marks <br>
<br>
reverse [string]<br>
      Reverses a sequence of characters<br>

count [string] [sequence]<br>
      Counts the amount of occurances in the string <br>
      To count something in longer than a word, concatinate the text  
      in quotation marks<br>
<br>
ascii [string]<br>
      Converts each character into its ASCII code<br>
<br>
utf [string]<br>
      Converts each character into its UTF-8 code<br>
<br>
convert [number] [base]<br>
      Converts a number from one base into another.<br>
         To define the starting base use:<br>
            Binary:      0b / bin<br>
            Decimal:     0d / dec / [empty]<br>
            Hexadecimal: 0x / hex<br>
         To define the convert-to base use:<br>
            Binary:      0b / bin / 02<br>
            Decimal:     0d / dec / 10 / [empty]<br>
            Hexadecimal: 0x / hex / 16<br>
