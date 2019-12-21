using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Soldiortype
{
    Soldior,    //雑兵
    Carpenter,  //大工
    Mercenary   //槍兵
}
public class SetSoldior : MonoBehaviour
{

    private SoldiorManager manager;

    [SerializeField, Tooltip("兵種")]
    private GameObject[] setSoldiorPrefs;

    [SerializeField, Tooltip("隊列間隔")]
    private float interval;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<SoldiorManager>();
        SoldiorSet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SoldiorSet()
    {
        for (int i = 0; i < manager.SoldiorArray.Length; i++)
        {
            // 雑兵をセット、生成
            manager.SoldiorArray[i] = Instantiate(setSoldiorPrefs[0]); 

            // 雑兵の初期位置を設定
            switch (i)
            {
                // 1人目
                case 0:
                    manager.SoldiorArray[i].GetComponent<Soldior>().OffsetPosition = new Vector3(-interval, 0);
                    break;
                // 2人目
                case 1:
                    manager.SoldiorArray[i].GetComponent<Soldior>().OffsetPosition = new Vector3(interval, 0);
                    break;
                // 以降
                default:
                    manager.SoldiorArray[i].GetComponent<Soldior>().OffsetPosition = new Vector3((interval * (i % 5)) - interval * 2, 0, (interval * (i / 5)) - interval * 2);
                    break;

            }
        }
    }
}
