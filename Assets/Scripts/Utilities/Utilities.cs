using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities
{

    public static Vector3 Wrap(Vector3 v, Vector3 min, Vector3 max)
    {
        Vector3 result = v;
        if (result.x > max.x) { result.x = min.x; }
        else if (result.x < min.x) { result.x = max.x; }

        if (result.y > max.y) { result.y = min.y; }
        else if (result.y < min.y) { result.y = max.y; }

        if (result.z > max.z) { result.z = min.z; }
        else if (result.z < min.z) { result.z = max.z; }

        return result;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
