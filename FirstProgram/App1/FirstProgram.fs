module FirstProgram

/// Split a string at spaces
let splitAtSpaces (text : string) = 
    text.Split ' '
    |> Array.toList

/// Analyze a string for duplicates
let wordCount text =
   let words   = splitAtSpaces text
   let wordSet = Set.ofList words
   let numWords= words.Length
   let numDump = words.Length - wordSet.Count
   (numWords, numDump)

///
    

