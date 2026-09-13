"""Small local GUI for the optional language and recruitment patches."""
import threading
import tkinter as tk
from tkinter import filedialog, ttk
from pathlib import Path
import queue

from patcher import Installation, LANGUAGE_FILES, GACHA


def main():
    window = tk.Tk()
    window.title("NTRSimulator · Client patches")
    window.geometry("680x460")
    window.minsize(640, 430)
    outer = ttk.Frame(window, padding=24)
    outer.pack(fill="both", expand=True)
    ttk.Label(outer, text="Choose your language", font=("Segoe UI", 20, "bold")).pack(anchor="w")
    ttk.Label(outer, text="Optional patches for CN 4.0.5136 · Tables 1152911").pack(anchor="w", pady=(4, 18))
    folder = tk.StringVar()
    guessed = Path(__file__).resolve().parents[1] / "Client/Game"
    if (guessed / "GF2_Exilium.exe").exists():
        folder.set(str(guessed))
    row = ttk.Frame(outer)
    row.pack(fill="x")
    ttk.Entry(row, textvariable=folder).pack(side="left", fill="x", expand=True)
    def browse():
        selected = filedialog.askdirectory(title="Choose the folder containing GF2_Exilium.exe")
        if selected:
            folder.set(selected)
    ttk.Button(row, text="Game folder…", command=browse).pack(side="right", padx=(8, 0))
    ttk.Label(outer, text="Close the game before switching. Original files are backed up automatically.", wraplength=610).pack(anchor="w", pady=(10, 14))
    status = tk.StringVar(value="Chinese remains the default until you enable English.")
    buttons = []
    events = queue.Queue()
    busy = False

    def run(action):
        nonlocal busy
        if busy:
            return
        if not folder.get().strip():
            status.set("Choose your game folder first.")
            return
        chosen_folder = folder.get()
        busy = True
        for button in buttons:
            button.configure(state="disabled")
        status.set("Preparing… English may need its first download (184 MB). Please leave this window open.")
        def worker():
            try:
                install = Installation(chosen_folder)
                result = {"english": lambda: install.english(download=True),
                          "chinese": lambda: install.restore(LANGUAGE_FILES),
                          "archive": install.archive,
                          "schedule": lambda: install.restore((GACHA,))}[action]()
                events.put(str(result))
            except Exception as error:
                events.put(str(error))
        threading.Thread(target=worker, daemon=True).start()

    def poll():
        nonlocal busy
        try:
            message = events.get_nowait()
        except queue.Empty:
            pass
        else:
            status.set(message)
            busy = False
            for button in buttons:
                button.configure(state="normal")
        window.after(150, poll)

    languages = ttk.Frame(outer)
    languages.pack(fill="x")
    for label, action in [("Enable English UI", "english"), ("Restore Chinese UI", "chinese")]:
        button = ttk.Button(languages, text=label, command=lambda a=action: run(a))
        button.pack(side="left", padx=(0, 10), ipady=6)
        buttons.append(button)
    ttk.Label(outer, text="English downloads a checked publisher reference once. Story dialogue stays Chinese.", wraplength=610).pack(anchor="w", pady=(10, 20))
    ttk.Label(outer, text="Recruitment archive", font=("Segoe UI", 13, "bold")).pack(anchor="w")
    ttk.Label(outer, text="Enable past banners on the client and set Recruitment:IncludePastBanners to true on your server.", wraplength=610).pack(anchor="w", pady=(4, 10))
    archive = ttk.Frame(outer)
    archive.pack(fill="x")
    for label, action in [("Enable past banners", "archive"), ("Restore banner schedule", "schedule")]:
        button = ttk.Button(archive, text=label, command=lambda a=action: run(a))
        button.pack(side="left", padx=(0, 10))
        buttons.append(button)
    ttk.Label(outer, textvariable=status, wraplength=610).pack(anchor="w", pady=(22, 0))
    def close():
        if busy:
            status.set("Please wait for the current operation to finish before closing.")
        else:
            window.destroy()
    window.protocol("WM_DELETE_WINDOW", close)
    poll()
    window.mainloop()


if __name__ == "__main__":
    main()
