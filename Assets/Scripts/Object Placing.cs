using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPlacing : MonoBehaviour
{
    int[][] matrix;
    int[] nos;
    
    void Start()
    {
        
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

    GameObject ClickSelect()
    {
        //Converting Mouse Pos to 2D (vector2) World Pos
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {
            Debug.Log(hit.transform.name);
            return hit.transform.gameObject;
        }
        else return null;
    }
}
