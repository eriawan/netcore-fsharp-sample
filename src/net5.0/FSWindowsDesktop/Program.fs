// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.Windows.Forms
open System.Drawing

let InitializeComponent (frmInitialized : Form) =
    let currentOSVersion = Environment.OSVersion.Version.Major.ToString() + "." + Environment.Version.Minor.ToString() + "." + Environment.OSVersion.Version.Build.ToString()
    let mutable btnHelloWinForm = new Button()
    btnHelloWinForm.Text <- "Hello F# WinForms"
    btnHelloWinForm.Location <- new Point(40, 100)
    btnHelloWinForm.Size <- new Size(180, 40)
    btnHelloWinForm.Click.Add(fun evtArgs -> MessageBox.Show("Runs on Windows version "+ currentOSVersion) |> ignore)
    frmInitialized.Controls.Add(btnHelloWinForm)
    ()

[<EntryPoint>]
[<STAThread>]
let main argv =
    let mainForm = new Form()
    let mainFormTitle = $"Hello World from F#! My name is {nameof mainForm}"
    mainForm.Text <- mainFormTitle
    mainForm.Size <- new Size(500, 350)
    InitializeComponent(mainForm)
    Application.Run(mainForm)
    0 // return an integer exit code