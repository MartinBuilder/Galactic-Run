using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChunk : MonoBehaviour
{
    [SerializeField]
    private Vector3 _size;
    public Vector3 Size { get { return _size; } }

    public Vector3 Position { get { return transform.position; } }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(_size.x, _size.y, _size.z));
    }
}