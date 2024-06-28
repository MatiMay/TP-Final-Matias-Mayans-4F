using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosScript : MonoBehaviour
{
    public GameObject[] objetos;
    GameObject nuevobj;
    int a = 1;
    // Start is called before the first frame update
    void Start()
    {
        nuevobj = Instantiate(objetos[0], new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            Destroy(nuevobj);
            if (a >= objetos.Length - 1)  a = 0; 
            else a++;
            nuevobj = Instantiate(objetos[a], new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Destroy(nuevobj);
            if (a <= 0) a = objetos.Length - 1;
            else a--;
            nuevobj = Instantiate(objetos[a], new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
