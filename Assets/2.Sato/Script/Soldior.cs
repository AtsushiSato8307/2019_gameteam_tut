using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldior : MonoBehaviour
{
    private GameObject player;

    [SerializeField, Tooltip("プレイヤーとのオフセット")]
    public Vector3 OffsetPosition;

    private Vector3 PlayerPosition { get { if (player != null) return player.transform.position; else return Vector2.zero; } }

    private Vector3 position;
    public Vector3 Position { get { return transform.position; } set { transform.position = value; } } 
    
    // Start is called before the first frame update
    void Start()
    {
        // キャッシュ
        player = GameObject.FindGameObjectWithTag("Player");
        // 位置初期化
        Position = PlayerPosition + OffsetPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Position = PlayerPosition + OffsetPosition;
    }
}
