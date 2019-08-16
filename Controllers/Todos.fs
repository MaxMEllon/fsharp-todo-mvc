namespace Controllers

open Giraffe
open Microsoft.AspNetCore.Http

module TodosController =
  let handlers : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
      GET >=> route "/todos" >=>
        fun next context ->
          text "Read" next context
    ]