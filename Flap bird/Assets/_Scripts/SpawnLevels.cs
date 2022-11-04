using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLevels : MonoBehaviour
{
    [SerializeField] GameObject[] levels;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateLevels", 15f, 13f);    
    }

    // Update is called once per frame
    public void CreateLevels()
    {
        Instantiate(levels[Random.Range(0, levels.Length)]);
    }
}
