using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    public int[][] matrix;
    int var1;
    int var2;
    int var3;
    int var4;
    int var5;
    int var6;
    int var7;
    int sum;
    public GameObject[] squares;
    GameObject gaObject;
    public GameObject g1;
    public GameObject g2;

    void Start()
    {
        gaObject = null;

        for (int i = 0; i < 6; i++)
        {

            for (int j = 0; j < 7; j++)
            {
                matrix[i][j] = 0;
            }
        }

        var1 = 0; var2 = 0; var3= 0; var4 = 0;var5= 0; var6 = 0;var7= 0;
    }

    // Update is called once per frame
    void Update()
    {
        sum = var1 + var2 + var3 + var4 + var5 + var6 + var7;
        gaObject = ClickSelect();
       

        if (Input.GetMouseButtonDown(0) && sum <42) 
        {
           // Debug.Log("Yes");
            if (gaObject.transform.name == "Square (5)" && var1 < 6)
            {
                
                float pos1 = (float)(-3.2 + 9 *(float)var1/7);
                if (sum % 2 == 0)
                {
                    Instantiate(g1, new Vector3(-6, pos1, 0f), Quaternion.identity);
                    
                }
                else
                {
                    Instantiate(g2, new Vector3(-6, pos1, 0f), Quaternion.identity);
                }
                var1++;
                
            }

            if (gaObject.transform.name == "Square (6)" && var2 < 6)
            {
                
                float pos1 = (float)(-3.2 + 9 * (float)var2 / 7);
                if (sum % 2 == 0)
                {
                    Instantiate(g1, new Vector3(-4, pos1, 0f), Quaternion.identity);
                }
                else
                {
                    Instantiate(g2, new Vector3(-4, pos1, 0f), Quaternion.identity);
                }
                var2++;

            }

            if (gaObject.transform.name == "Square (7)" && var3 < 6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var3 / 7);
                if (sum % 2 == 0)
                { Instantiate(g1, new Vector3(-2, pos1, 0f), Quaternion.identity); }
                else
                {
                    Instantiate(g2, new Vector3(-2, pos1, 0f), Quaternion.identity);
                }
                var3++;

            }

            if (gaObject.transform.name == "Square (8)" && var4 < 6)
            {
                
                float pos1 = (float)(-3.2 + 9 * (float)var4 / 7);
                if (sum % 2 == 0)
                { Instantiate(g1, new Vector3(0, pos1, 0f), Quaternion.identity); }
                else
                {
                    Instantiate(g2, new Vector3(0, pos1, 0f), Quaternion.identity);
                }
                var4++;

            }

            if (gaObject.transform.name == "Square (9)" && var5 < 6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var5 / 7);
                if (sum % 2 == 0)
                { Instantiate(g1, new Vector3(2, pos1, 0f), Quaternion.identity); }
                else
                {
                    Instantiate(g2, new Vector3(2, pos1, 0f), Quaternion.identity);
                }
                var5++;

            }

            if (gaObject.transform.name == "Square (10)" && var6 < 6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var6 / 7);
                if (sum % 2 == 0)
                { Instantiate(g1, new Vector3(4, pos1, 0f), Quaternion.identity); }
                else
                {
                    Instantiate(g2, new Vector3(4, pos1, 0f), Quaternion.identity);
                }
                var6++;

            }

            if (gaObject.transform.name == "Square (11)" && var7<6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var7 / 7);
                if (sum % 2 == 0)
                { Instantiate(g1, new Vector3(6, pos1, 0f), Quaternion.identity); }
                    else
                {
                    Instantiate(g2, new Vector3(6, pos1, 0f), Quaternion.identity);
                }
                var7++;

            }
        }
    }

    

    GameObject ClickSelect()
    {
        
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {
           //Debug.Log(hit.transform.name);
            return hit.transform.gameObject;
        }
        else return null;
    }

   

}



