# 🎥 Real-Time Pose Animation & Visualization with OpenCV, MediaPipe & Unity 🔥
![My Image](MotionCapture.png)
Welcome to the ultimate **Pose Detection and Animation** project! This repo combines the power of **MediaPipe's AI-driven pose estimation**, **OpenCV's video processing**, and **Unity’s 3D engine** to capture human body movements from a video, process them, and animate a 3D model in real-time. All smooth, all slick. 💪✨

---

## 🚀 What’s Inside?

- **Python Script:** Uses OpenCV and MediaPipe to:
  - Read video frames 🎞️
  - Detect human pose landmarks in real-time 🧍‍♂️🧍‍♀️
  - Save pose coordinates frame-by-frame for animation
  
- **Unity C# Scripts:**
  - **AnimationCode.cs:** Loads pose data and animates a rigged 3D model based on the recorded landmark positions.
  - **LineCode.cs:** Draws dynamic lines between points to visualize bones or connections in the rig — making your model come alive! 🦴✨

---

## 🎯 Features

- Real-time pose detection from videos using state-of-the-art AI 🤖
- Frame-by-frame animation playback inside Unity 🎮
- Lightweight, modular, and easy to expand with your own models or input sources
- Simple, clean code with comments for beginners and pros alike 👨‍💻👩‍💻

---

## 📦 Getting Started

### Requirements

- Python 3.7+
- OpenCV (`opencv-python`)
- MediaPipe (`mediapipe`)
- Unity 2020.3+ or newer

### Setup & Run Python Script

1. Replace `'video_path :)'` in the Python script with your video file path.
2. Run the Python script to process the video and generate `AnimationFile.txt`:
   ```bash
   Mediapipe.py
