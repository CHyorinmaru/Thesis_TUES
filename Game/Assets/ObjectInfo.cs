using System;
using UnityEngine;

public class ObjectInfo : MonoBehaviour
{
    public Object info;

    public void SetInfo(Object info)
    {
        this.info = info;

        var stringPos = info.position.Split(',');
        Vector3 pos = new Vector3(Convert.ToInt32(stringPos[0]), Convert.ToInt32(stringPos[1]), Convert.ToInt32(stringPos[2]));
        transform.position = pos;

        var stringSize = info.size.Split(',');
        GetComponent<BoxCollider>().size = new Vector3(Convert.ToInt32(stringSize[0]), Convert.ToInt32(stringSize[1]), Convert.ToInt32(stringSize[2]));
    }
}
