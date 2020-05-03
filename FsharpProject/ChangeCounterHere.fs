namespace FsharpProject

module ChangeCounterHere =

    open System
    open Elmish
    open Elmish.WPF

    type Model = {
        Counter: int
        }

    let init() = {
        Counter = 1 // Changing this value changes the initial counter value, which can be checked by pressing the Reset button.
        }
        
    type Msg =
        | AddToCounter
        | SubtractFromCounter
        | Reset

    let GetIncrement () =
        1 // Changing this value changes the increment ammount, which can be checked by pressing either the + or the - button.

    let update msg m =
        match msg with
        | AddToCounter -> {m with Counter = m.Counter + GetIncrement()}
        | SubtractFromCounter -> {m with Counter = m.Counter - GetIncrement()}
        | Reset -> init()

    let bindings() =
        [
        "Counter" |> Binding.oneWay (fun m -> m.Counter)
        "AddToCounter" |> Binding.cmd AddToCounter
        "SubtractFromCounter" |> Binding.cmd SubtractFromCounter
        "Reset" |> Binding.cmd Reset
        ]


    // This is the function that gets called by the C# project to initialize a kind of "ViewModel" to serve the C# WPF.
    let Main argv = Program.mkSimpleWpf init update bindings