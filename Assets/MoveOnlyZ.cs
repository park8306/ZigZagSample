using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    public float x;
    public float y;
    Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()   // ���߿� ������Ʈ ��� ������Ʈ�� �� ����� �Ŀ� ���� ��.
    {
        var pos = transform.position;
        pos.x = x;
        pos.y = y;
        transform.position = pos;
        transform.rotation = rotation;
    }
}
