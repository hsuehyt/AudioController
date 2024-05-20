# Audio Pause and Resume Script for Unity

This Unity C# script allows you to toggle the pause and resume functionality of an `AudioSource` using the spacebar. When the spacebar is pressed, the audio will either pause if it is playing or resume from the same point if it is paused.

## Features

- **Pause Audio:** Press the spacebar to pause the currently playing audio.
- **Resume Audio:** Press the spacebar again to resume the audio from where it was paused.
- **Simple Integration:** Easy to integrate into any Unity project with an `AudioSource` component.

## Requirements

- Unity 2019.4 or higher
- C# scripting support

## Installation

1. **Download the Script:**
   - Download the `AudioController.cs` script from this repository.

2. **Add the Script to Your Project:**
   - Place the `AudioController.cs` script in the `Assets/Scripts` directory of your Unity project.

3. **Attach the Script to a GameObject:**
   - In the Unity Editor, select the GameObject that has the `AudioSource` component you want to control.
   - Click on `Add Component` in the Inspector and search for `AudioController` to attach the script.

4. **Assign the AudioSource:**
   - Ensure the GameObject has an `AudioSource` component attached. The script will automatically get the `AudioSource` component from the same GameObject.

## Usage

- **Play Your Scene:**
  - Start your scene in Unity.
  - Press the spacebar to toggle pause and resume for the audio.
