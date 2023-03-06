using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Place : MonoBehaviour
{
    public int[,] matrix = new int [6, 7];
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
                matrix[i,j] = 0;
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
          
            if (gaObject.transform.name == "Square (5)" && var1 < 6)
            {
                
                float pos1 = (float)(-3.2 + 9 *(float)var1/7);
                if (sum % 2 == 0)
                {
                    Instantiate(g1, new Vector3(-6, pos1, 0f), Quaternion.identity);
                    matrix[5 - var1,0] = 1;
                    if(wincheck())
                    {
                        SceneManager.LoadScene("Win");
                    }
                    
                }
                else
                {
                    Instantiate(g2, new Vector3(-6, pos1, 0f), Quaternion.identity);
                    matrix[5 - var1,0] = 2;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Lose");
                    }
                }
               
                var1++;
                
            }

            if (gaObject.transform.name == "Square (6)" && var2 < 6)
            {
                
                float pos1 = (float)(-3.2 + 9 * (float)var2 / 7);
                if (sum % 2 == 0)
                {
                    Instantiate(g1, new Vector3(-4, pos1, 0f), Quaternion.identity);
                    matrix[5 - var2,1] = 1;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Win");
                    }
                }
                else
                {
                    Instantiate(g2, new Vector3(-4, pos1, 0f), Quaternion.identity);
                    matrix[5 - var2,1] = 2;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Lose");
                    }
                }
                var2++;

            }

            if (gaObject.transform.name == "Square (7)" && var3 < 6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var3 / 7);
                if (sum % 2 == 0)
                { 
                    Instantiate(g1, new Vector3(-2, pos1, 0f), Quaternion.identity);
                    matrix[5 - var3, 2] = 1;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Win");
                    }

                }
                else
                {
                    Instantiate(g2, new Vector3(-2, pos1, 0f), Quaternion.identity);
                    matrix[5 - var3,2] = 2;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Lose");
                    }
                }
                var3++;

            }

            if (gaObject.transform.name == "Square (8)" && var4 < 6)
            {
                
                float pos1 = (float)(-3.2 + 9 * (float)var4 / 7);
                if (sum % 2 == 0)
                { 
                    Instantiate(g1, new Vector3(0, pos1, 0f), Quaternion.identity);
                    matrix[5 - var4,3] = 1;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Win");
                    }
                }
                else
                {
                    Instantiate(g2, new Vector3(0, pos1, 0f), Quaternion.identity);
                    matrix[5 - var4, 3] = 2;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Lose");
                    }
                }
                var4++;

            }

            if (gaObject.transform.name == "Square (9)" && var5 < 6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var5 / 7);
                if (sum % 2 == 0)
                { 
                    Instantiate(g1, new Vector3(2, pos1, 0f), Quaternion.identity);
                    matrix[5 - var5, 4] = 1;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Win");
                    }
                }
                else
                {
                    Instantiate(g2, new Vector3(2, pos1, 0f), Quaternion.identity);
                    matrix[5 - var5, 4] = 2;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Lose");
                    }
                }
                var5++;

            }

            if (gaObject.transform.name == "Square (10)" && var6 < 6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var6 / 7);
                if (sum % 2 == 0)
                { 
                    Instantiate(g1, new Vector3(4, pos1, 0f), Quaternion.identity);
                    matrix[5 - var6, 5] = 1;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Win");
                    }
                }
                else
                {
                    Instantiate(g2, new Vector3(4, pos1, 0f), Quaternion.identity);
                    matrix[5 - var6, 5] = 2;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Lose");
                    }
                }
                var6++;

            }

            if (gaObject.transform.name == "Square (11)" && var7<6)
            {
                float pos1 = (float)(-3.2 + 9 * (float)var7 / 7);
                if (sum % 2 == 0)
                {
                    Instantiate(g1, new Vector3(6, pos1, 0f), Quaternion.identity);
                    matrix[5- var7,6] = 1;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Win");
                    }
                }
                    else
                {
                    Instantiate(g2, new Vector3(6, pos1, 0f), Quaternion.identity);
                    matrix[5 - var7,6] = 2;
                    if (wincheck())
                    {
                        SceneManager.LoadScene("Lose");
                    }
                }
                var7++;

            }
        }
        if(sum ==42)
        {
            SceneManager.LoadScene("Draw");
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

   bool wincheck()
    {
        for (int i =5;i>=3;i--)
        {
            for(int j = 0;j<7;j++)
            {
                
                    if (matrix[i, j] == matrix[i - 1, j] && matrix[i, j] == matrix[i - 2, j] && matrix[i, j] == matrix[i - 3, j] && matrix[i,j] != 0)
                    {
                    Debug.Log("Yes");
                        return true;
                    }

                if (j <= 3)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i, j + 2] && matrix[i, j] == matrix[i, j + 3] && matrix[i, j] != 0)
                    {
                        return true;
                    }

                    if (matrix[i, j] == matrix[i - 1, j + 1] && matrix[i, j] == matrix[i - 2, j + 2] && matrix[i, j] == matrix[i - 3, j + 3] && matrix[i, j] != 0)
                    {
                        return true;
                    }
                }

                if(j>=3)
                {
                    if (matrix[i, j] == matrix[i - 1, j - 1 ] && matrix[i, j] == matrix[i - 2, j- 2] && matrix[i, j] == matrix[i - 3, j - 3] && matrix[i, j] != 0)
                    {
                        return true;
                    }
                }
                    
            }
        }


        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Debug.Log(i);
                Debug.Log(j);
                Debug.Log(matrix[i, j]);

            }
        }
        return false;
    }

}



