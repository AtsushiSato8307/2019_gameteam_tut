using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldiorManager : MonoBehaviour
{
    [SerializeField, Tooltip("軍団の人数")]
    public int SoldiorNumber;

    [SerializeField, Tooltip("軍団の配列")]
    public GameObject[] SoldiorArray;


    // Start is called before the first frame update
    void Awake()
    {
        SoldiorArray = new GameObject[SoldiorNumber];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Alignment()
    {
        
    }
}
