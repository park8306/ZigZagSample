using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyZ : MonoBehaviour
{
    public Transform followTr;
    public Vector3 offset;

    public float x;
    public float y;
    private void Start()
    {
        offset = transform.position - followTr.position;
        x = transform.position.x;
        y = transform.position.y;
    }

    private void Update()
    {
        var pos =  offset + followTr.position;
        pos.x = x;
        pos.y = y;
        transform.position = pos;
    }
    //public float x;
    //public float y;
    //Quaternion rotation;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    x = transform.position.x;
    //    y = transform.position.y;
    //    rotation = transform.rotation;
    //}

    //// Update is called once per frame
    //void LateUpdate()   // ���߿� ������Ʈ ��� ������Ʈ�� �� ����� �Ŀ� ���� ��.
    //{
    //    var pos = transform.position;
    //    pos.x = x;
    //    pos.y = y;
    //    transform.position = pos;
    //    transform.rotation = rotation;
    //}
}
