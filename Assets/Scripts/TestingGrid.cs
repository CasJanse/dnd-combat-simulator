using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DND.Utils;

public class TestingGrid : MonoBehaviour
{

    private Grid<bool> grid;

    private void Start()
    {
        grid = new Grid<bool>(20, 20, 5f, new Vector3(-50, -50));
        grid.SetValue(0, 0, true);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            grid.SetValue(Utils.GetMouseWorldPosition(), true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(Utils.GetMouseWorldPosition()));
        }
    }
}
