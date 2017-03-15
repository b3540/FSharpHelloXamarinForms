namespace FSPCLFS

open FSPCL
open Xamarin.Forms

type FSMainPage() as self = 
    inherit MainPage()
    do
        self.BindingContext <- new FSMainPageViewModel()
        self.TitleLabel.Text <- "Welcome to F#"
 