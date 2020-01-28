using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingGrid : MonoBehaviour
{

    private void Start()
    {
        Grid grid = new Grid(10, 5, 10f);
        grid.SetValue(1, 2, 56);
    }
}
