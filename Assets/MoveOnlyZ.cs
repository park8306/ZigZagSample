using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()   // 나중에 업데이트 모든 업데이트가 다 실행된 후에 실행 됨.
    {
        var pos = transform.position;
        pos.x = x;
        pos.y = y;
        transform.position = pos;
    }
}
