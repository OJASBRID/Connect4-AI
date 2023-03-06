using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacing : MonoBehaviour
{
    int[][] matrix;
    int[] nos;
    int player;
    void Start()
    {
        player = 1;
        for(int i = 0;i<6;i++)
        {
            
            for(int j =0;j<7;j++)
            {
                matrix[i][j] = 0;
            }
        }

        for(int j = 0;j<7;j++)
        {
            nos[j] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
