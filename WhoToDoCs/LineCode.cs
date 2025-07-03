using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCode : MonoBehaviour
{
    // Reference to the LineRenderer component
    LineRenderer lineRenderer;

    // Two points between which the line will be drawn
    public Transform origin;
    public Transform destination;

    // Called once at the start
    void Start()
    {
        // Grab the LineRenderer component attached to this GameObject
        lineRenderer = GetComponent<LineRenderer>();

        // Set the width of the line at the start and end
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    // Called once every frame
    void Update()
    {
        // Update the start position of the line to match the origin's position
        lineRenderer.SetPosition(0, origin.position);

        // Update the end position of the line to match the destination's position
        lineRenderer.SetPosition(1, destination.position);
    }
}