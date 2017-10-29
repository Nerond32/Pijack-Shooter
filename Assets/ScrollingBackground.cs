using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    static Vector3 initPosition;
    void Start()
    {
        initPosition = this.transform.position;
    }

    private void Update()
    {
        Vector3 position = this.transform.position;
        if (position.y < -8.9f)
        {
            position = initPosition;
        }
        else
        {
            position.y = position.y - 0.1f;
        }
        this.transform.position = position;
    }
}