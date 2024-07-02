# Baldi's Basics Classic VR

A standalone version of Baldi's Basics Classic (not the remaster) with full 6DOF VR added. Supports PCVR (OpenVR) and Quest.

Based on [this](https://porkypowers.itch.io/baldi-open-source-classic-party) decompile of Classic 1.4.3.

## Issues
- Some sprite layering issues with the XR Rig's hands.
- The Quest version has various graphical issues. Nothing game breaking, but it doesn't look as nice as the PC version.

## Installation
### PCVR
1) Download the latest Windows zip file from the [Releases](https://github.com/hanabira-mitsu/bbvr/releases/latest) page.
2) Extract the zip file.
3) Run `Baldi's Basics Classic VR.exe`, the game should automatically run your default OpenXR runtime. 

### Quest
1) Download the latest Android APK from [Releases](https://github.com/hanabira-mitsu/bbvr/releases/latest) page.
   
#### SideQuest
2) Ensure headset is connected.
3) Click "Install APK file from folder on computer" and select the APK.

#### ADB
2) Ensure headset is connected.
3) `cd` to the folder containing the APK.
4) Install with `adb install`.
