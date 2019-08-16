namespace Controllers

open Giraffe
open Microsoft.AspNetCore.Http

module TodosController =
  let handlers : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
      GET >=> route "/todos" >=>
        fun next context ->
          // Giraffe.ResponseWriters.text 
          // see: https://github.com/giraffe-fsharp/Giraffe/blob/2e5dcae47b71c5fa12bbf84166681a11c910d951/src/Giraffe/ResponseWriters.fs#L301-L305
          text "Read" next context
    ]