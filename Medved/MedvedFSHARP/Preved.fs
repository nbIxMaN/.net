namespace MedvedFSHARP
open MedvedBASIC

type MedvedFSHARP() =
    inherit MedvedBASIC()
        override this.MeetMedved() = 
            printfn("Preved from F#")
            base.MeetMedved()