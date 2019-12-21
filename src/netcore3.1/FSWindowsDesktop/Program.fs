// Learn more about F# at http://fsharp.org

open System
open System.Windows.Forms
open System.Drawing

let InitializeComponent (frmInitialized : Form) =
    let currentOSVersion = Environment.OSVersion.Version.Major.ToString() + "." + Environment.Version.Minor.ToString() + "." + Environment.OSVersion.Version.Build.ToString()
    let mutable btnHelloWinForm = new Button()
    btnHelloWinForm.Text <- "Hello F# WinForms"
    btnHelloWinForm.Location <- new Point(40, 100)
    btnHelloWinForm.Click.Add(fun evtArgs -> MessageBox.Show("Runs on Windows version "+ currentOSVersion) |> ignore)
    frmInitialized.Controls.Add(btnHelloWinForm)
    ()

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let mainForm = new Form()
    InitializeComponent(mainForm)
    Application.Run(mainForm)
    0 // return an integer exit code
