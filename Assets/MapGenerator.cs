using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MapGenerator : MonoBehaviour
{
    public Transform cubeParent;
    public Cube baseItem;
    public int makeCount = 20;

    private void Awake()
    {
        GeneratorCubes();
    }
    // 랜덤하게 큐브 생성
    [ContextMenu("큐브 생성")]
    private void GeneratorCubes()
    {
        DestroyExistCube();

        Vector3 previousPos = baseItem.transform.localPosition;
        for (int i = 0; i < makeCount; i++)
        {
            var newCube = Instantiate(baseItem, cubeParent);
            newCube.transform.localRotation = Quaternion.identity;
            if (Random.Range(0, 2) == 0)
                previousPos += new Vector3(1, 0, 0);
            else
                previousPos += new Vector3(0, 0, 1);

            newCube.transform.localPosition = previousPos;

            previousPos = newCube.transform.localPosition;
        }
    }

    private void DestroyExistCube()
    {
        var allCube = cubeParent.GetComponentsInChildren<Cube>();
        foreach (var item in allCube)
        {
            DestroyImmediate(item.gameObject);
        }
    }
}
