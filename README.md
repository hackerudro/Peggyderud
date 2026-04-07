# Peggyderud

Peggyderud is a Windows desktop voice assistant written in C# (.NET Framework 4.7.2, Windows Forms). It listens to spoken commands through the system microphone, matches them against a set of predefined grammars, and responds with prerecorded audio clips, text-to-speech, application launches, browser automation, and AutoHotKey scripts.

> Despite the "AI" branding of earlier versions, Peggyderud is a **rule-based** assistant: speech recognition is handled by `System.Speech.Recognition.SpeechRecognitionEngine` and commands are dispatched through a large `switch` statement. There is no machine learning or LLM in the loop.

## Features

- **Voice-controlled chat** with personality clips (Bengali + English)
- **Calculator mode** — say digits and operators to drive Windows Calculator
- **Google Chrome automation** — open tabs, search, navigate, control YouTube playback and volume
- **YouTube song search** — say a song name from `Grammers/Song Names.txt` to search and auto-open the first result
- **Facebook helpers** — auto-login and pre-canned chats with selected contacts
- **CMD utilities** — open shell, run `ipconfig`, `ping`, etc. by voice
- **App launchers** — Notepad, MS Paint, GIMP (with multi-step image workflows), Calculator
- **VPN connect / disconnect** via AutoHotKey scripts
- **Screenshot, speed test, MP3 download** via AutoHotKey scripts
- **Animated UI** — custom gradient panels and GIF picture boxes driven by Windows Forms timers

## Project Structure

```
Peggyderud/
├── Peggyderud/                # C# Windows Forms project
│   ├── Form1.cs                # Main form + command dispatcher (~770 lines)
│   ├── Form1.Designer.cs       # Designer-generated UI
│   ├── Program.cs              # Entry point
│   ├── gradientpanel.cs        # Custom gradient Panel control
│   ├── Properties/             # AssemblyInfo, Resources, Settings
│   ├── Peggyderud.csproj
│   ├── App.config
│   └── packages.config
├── Grammers/                   # Speech recognition vocabulary (text files)
│   ├── Global Commands.txt
│   ├── Chatting.txt
│   ├── Calculator Commands.txt
│   ├── Commands.txt
│   ├── Google Chrome Commands.txt
│   ├── Software Commands.txt
│   ├── Song Names.txt
│   └── Questions.txt
├── wav files/                  # Prerecorded voice responses
├── Gifs/                       # UI animations
├── auto hot key scripts/       # Compiled AutoHotKey automation scripts
├── packages/                   # NuGet packages
└── Peggyderud.sln
```

## Requirements

- Windows 10 or 11
- .NET Framework 4.7.2
- Visual Studio 2019 or newer
- A working microphone configured as the default Windows recording device
- Google Chrome (for browser-related commands)
- Optional: GIMP 2.10 (for image editing commands), an OpenVPN-style client (for VPN commands), NirSoft WebBrowserPassView (for the saved-password command)

## Build & Run

1. Clone the repository:
   ```sh
   git clone https://github.com/hackerudro/Peggyderud.git
   ```
2. Open `Peggyderud.sln` in Visual Studio.
3. Restore NuGet packages (Visual Studio does this automatically on first build).
4. Build the solution (`Ctrl+Shift+B`).
5. Run with `F5`.

> The application currently uses **absolute paths** in `Form1.cs` for the `Grammers/`, `wav files/`, and `auto hot key scripts/` directories. If your clone is not located at `C:\Users\mgmor\OneDrive\My Projects\Peggyderud\`, update the path constants in `Form1.cs` (or refactor them to use `Application.StartupPath`).

## Adding New Voice Commands

1. Add the trigger phrase to the appropriate file in `Grammers/` (one phrase per line).
2. Add a matching `case "<phrase>":` block to the `switch` in `Spe_SpeechRecognized` inside `Form1.cs`.
3. Rebuild and run.

## Dependencies

NuGet packages (see `packages.config`):

- DotNetOpenAuth (Core, OAuth, OpenID)
- MetroModernUI 1.4.0.0
- Microsoft.Net.Http 2.0.20505.0

External assemblies:

- `Bunifu_UI_v1.4.dll` — referenced via a HintPath in `Peggyderud.csproj`
- `System.Speech` — shipped with .NET Framework

## Notes & Caveats

- This is a personal hobby project from ~2019-2020 and the code reflects that — long switch statements, hardcoded paths, no tests.
- The wake/sleep word is **"peggyderud"** (e.g. *"you can sleep now peggyderud"* exits the app).
- The "Show all the saved password" command relies on NirSoft `WebBrowserPassView.exe` and writes a `savedpass.txt` file to the desktop. Use it only on machines you own.

## License

No license specified. All rights reserved by the author.
