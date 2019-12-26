using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldiorManager : MonoBehaviour
{
    [SerializeField, Tooltip("軍団の人数")]
    public int SoldiorNumber;

    [SerializeField, Tooltip("軍団の配列")]
    public GameObject[] SoldiorArray;

    [SerializeField, Tooltip("カウンター")]
    private Text counter;


    // Start is called before the first frame update
    void Awake()
    {
        SoldiorArray = new GameObject[SoldiorNumber];
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = SoldiorNumber.ToString() + "人";
    }
    private void Alignment()
    {
        
    }
}
