# penknife
Little multitool written in C#

List of commands:

help  /  h
      Help Menu

length [string]
      Returns the length of a string. To count something longer than a
      word, concatinate the text in quotation marks

reverse [string]
      Reverses a sequence of characters

count [string] [sequence]
      Counts the amount of occurances in the string 
      To count something in longer than a word, concatinate the text  
      in quotation marks

ascii [string]
      Converts each character into its ASCII code

utf [string]
      Converts each character into its UTF-8 code

convert [number] [base]
      Converts a number from one base into another.
         To define the starting base use:
            Binary:      0b / bin
            Decimal:     0d / dec / [empty]
            Hexadecimal: 0x / hex
         To define the convert-to base use:
            Binary:      0b / bin / 02
            Decimal:     0d / dec / 10 / [empty]
            Hexadecimal: 0x / hex / 16
