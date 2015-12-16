
let doubleClick (filePath: string) = ignore <| System.Diagnostics.Process.Start filePath

[<EntryPoint>]
let main argv =
    if (Array.length argv >= 1)
        then doubleClick <| Array.item 0 argv
        else printfn "Usage: db FILE_PATH"
    0 // 整数の終了コードを返します
