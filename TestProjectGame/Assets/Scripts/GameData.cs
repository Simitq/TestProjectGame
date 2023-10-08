using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Runtime.Serialization;

namespace Scripts
{
    [Serializable]
    public class GameData
    {
        public int healthPlayer;
        public Vector3 positionPlayer;
        public Quaternion rotationPlayer;
        public bool facingRight;
    }
}