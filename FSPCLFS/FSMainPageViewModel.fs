namespace FSPCLFS

open System
open System.ComponentModel

type FSMainPageViewModel() =
  let _propertyChanged = new Event<_,_>()
  let mutable _name = String.Empty
  let mutable _value = String.Empty
  member x.Name
    with get() = _name
     and set(value) =
       _name <- value
       _propertyChanged.Trigger(x, PropertyChangedEventArgs("Name"))
  member x.Value
    with get() = _value
     and set(value) =
       _value <- value
       _propertyChanged.Trigger(x, PropertyChangedEventArgs("Value"))
  interface INotifyPropertyChanged with
    [<CLIEvent>]
    member x.PropertyChanged = _propertyChanged.Publish
