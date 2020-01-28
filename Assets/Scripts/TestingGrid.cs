using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DND.Utils;

public class TestingGrid : MonoBehaviour
{

    private Grid grid;

    private void Start()
    {
        grid = new Grid(20, 20, 5f, new Vector3(-50, -50));
        //grid.SetValue(new Vector3(21, 14), 56);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(grid.GetValue(Utils.GetMouseWorldPosition()));
        }
    }
}
