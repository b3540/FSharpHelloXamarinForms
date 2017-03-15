namespace FSPCLFS

open FSPCL

type FSApp() as self =
    inherit App()
        do
            self.MainPage <- new FSMainPage();