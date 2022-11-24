using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Spawner", menuName = "Spawner", order = 1)]

public class Spawner : ScriptableObject
{
    [SerializeField]
    public List<Transform> transform = new List<Transform>();
    public List<Vector3> location = new List<Vector3>();
}
