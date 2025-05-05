using System;
using UnityEngine;

namespace Mino
{
    public class MinoView: MonoBehaviour
    {
        public Vector3 rotationPoint;
        
        public void UpdateMinoPosition(int widthIndex, int heightIndex)
        {
            Debug.Log("widthIndex: "+widthIndex+", heightIndex: "+heightIndex);
            transform.localPosition = new Vector3(widthIndex, heightIndex, 0);
        }

        public void UpdateMinoRotation()
        {
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), 90);
        }
    }
}