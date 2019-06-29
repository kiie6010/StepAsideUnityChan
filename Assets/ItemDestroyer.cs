using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

    // unitychan
    private GameObject unitychan;
    // unitychanとこのオブジェクトの距離
    private float distance;

	// Use this for initialization
	void Start () {
        
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //UnityちゃんとDestroyerの位置（z座標）の差を求める
        this.distance = unitychan.transform.position.z - this.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {
        
        //Unityちゃんの位置に合わせてDestroyerの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - distance);
    }

    // Itemオブジェクトに触れたら、それを消滅
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "CoinTag" || other.gameObject.tag == "TrafficConeTag") {
            Destroy(other.gameObject);
        }
    }
}
