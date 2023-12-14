using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrearPrefabs : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    public void CreaCubo()
    {
        for (var i = 0; i < 1; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }
}
