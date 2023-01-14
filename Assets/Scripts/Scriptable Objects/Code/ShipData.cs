using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class ShipData : ScriptableObject
{
    public int shipHealth;
    public float shipThrustSpeed;
    public float shipRotationSpeed;
    public Vector2 shipPosition;
}
