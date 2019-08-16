namespace Models.Todo

type TodoModel(id: string, txt: string, status: bool) =
  member this.Id = id
  member this.Text = txt
  member this.Done = status

  new ((id: string, txt: string, status: bool)) = TodoModel(id, txt, status)

  member this.Did() =
    this.Done = true
  
  member this.UpdateText(txt: string) =
    this.Text = txt


type TodoCollection(arr: (string * string * bool) list) =
  member this.Todos = List.map TodoModel arr
    