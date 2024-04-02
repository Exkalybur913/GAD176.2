using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class WeaponTypes : ScriptableObject
{
    [Range(50, 250)]
    [Tooltip("m/s")]
    public float velocity = 400;

    [Range(0, 250)]
    [Tooltip("seconds")]
    public float reloadTime;

    [Range(00, 250)]
    [Tooltip("pts")]
    public float damage;

    [Range(00, 250)]
    [Tooltip("meters")]
    public float range;
}
