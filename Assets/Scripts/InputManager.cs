using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace inputManager
{
    public struct TouchInfo
    {
        public TouchInfo(Vector3 startPos, Vector3 direction, bool isInteractableUI, TouchPhase phase)
        {
            StartPos = startPos;
            Direction = direction;
            IsInteractableUI = isInteractableUI;
            Phase = phase;
        }
        public Vector3 StartPos { get; set; }
        public Vector3 Direction { get; set; }
        public bool IsInteractableUI { get; set; }
        public TouchPhase Phase { get; set; }
    }
}



