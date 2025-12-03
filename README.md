📌 Overview

WatchDog is a simple console-based utility designed to check whether a specific process is running on your system.
It is currently in its foundation stage, focusing on the most basic functionality:

✔ Accept a process name from the user
✔ Validate input
✔ Check if the process is running
✔ Display whether any matching processes were found

This is the groundwork for a much larger tool that will evolve into a full process management utility.

🚧 Current Status: In Development

This is the very first functional version, meant to build the core logic before expanding into more powerful features.

As of now, WatchDog serves as a simple process existence checker using the System.Diagnostics API.

🔮 Planned Features

WatchDog will be gradually expanded to include:

📝 Process Listing

View all active processes in a clean, formatted list.

🔍 Detailed Process Information

PID (Process ID)

Memory usage

Multiple instances detection

More system details

❌ Process Termination

Optionally terminate a running process from within WatchDog.

⏱ Watch Mode

Continuously monitor a process until it starts, ends, or changes state.

📊 Statistics & Logging

Track how many times processes were found/not found during a session.

🖥 WinForms Version

A full GUI version featuring:

Process list view

Buttons for Kill, Refresh, Details

Real-time monitoring possibly

Better accessibility and navigation

The WinForms version will be developed once the console core is fully stable.
