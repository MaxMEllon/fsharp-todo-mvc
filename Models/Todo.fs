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

type TodoCollection() =
  static member NewTodo(item: (string * string * bool)) =
    let todo = TodoModel(item)
    // do
      // todo: create query
    todo
  
  static member All() =
    // do
      // todo: select query
    // todo: dummy data
    List.map TodoModel [("01", "sample", false); ("02", "sample", true)] 