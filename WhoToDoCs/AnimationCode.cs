using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Threading;

public class AnimationCode : MonoBehaviour
{
    // Array of GameObjects representing body parts/joints
    public GameObject[] Body;

    // List to hold lines read from the animation file
    List<string> lines;

    // Counter to track which frame of animation we're on
    int counter = 0;

    // Called once at the start
    void Start()
    {
        // Read all lines from the AnimationFile.txt into the list
        lines = System.IO.File.ReadLines("Assets/AnimationFile.txt").ToList();
    }

    // Called once every frame
    void Update()
    {
        // Split the current frame's data by commas into an array of point coordinates
        string[] points = lines[counter].Split(',');

        // Loop through 33 body points (0 to 32)
        for (int i = 0; i <= 32; i++)
        {
            // Parse x, y, z coordinates from the points array and scale them down
            float x = float.Parse(points[0 + (i * 3)]) / 100;
            float y = float.Parse(points[1 + (i * 3)]) / 100;
            float z = float.Parse(points[2 + (i * 3)]) / 300;

            // Set the local position of the corresponding body GameObject
            Body[i].transform.localPosition = new Vector3(x, y, z);
        }

        // Move to the next frame
        counter += 1;

        // Loop back to the first frame once we reach the end
        if (counter == lines.Count) { counter = 0; }

        // Pause for 30 milliseconds to control animation speed
        Thread.Sleep(30);
    }
}
