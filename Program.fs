module Expressive.Program

open System
open Glutinum.Express
open Glutinum.ExpressServeStaticCore
open Glutinum.BodyParser
open Fable.Core.JsInterop

let app = express.express ()

app.``use`` (bodyParser.json ())

app.get ("/", (fun (req: Request) (res: Response) -> res.send {| message = "Hello Fable!" |} |> ignore))



// Define a function to construct a message to print
let from whom = sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    app.listen (3000, "0.0.0.0", (fun _ -> printfn "Started app at 0.0.0.0:3000"))
    |> ignore

    0 // return an integer exit code
