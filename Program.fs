// Learn more about F# at http://fsharp.org
module TodoMvc

open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe
open Controllers

let routes =
  choose [
    route "/" >=> text "Hello, World from F#"
    TodosController.handlers
  ]

let configureApp (app : IApplicationBuilder) =
  app.UseGiraffe routes

let configureService (services : IServiceCollection) =
  services.AddGiraffe() |> ignore

[<EntryPoint>]
let main _ =
  WebHostBuilder()
    .UseKestrel()
    .Configure(Action<IApplicationBuilder> configureApp)
    .ConfigureServices(configureService)
    .Build()
    .Run()
  0