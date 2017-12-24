using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour {

    //得点を表示するテキスト
    private GameObject pointText;

	private int Frag = 0;

	// 得点
	private int myscore=0;

	// Use this for initialization
	void Start () {
		this.pointText = GameObject.Find("PointText");
	}

	void Update () {
		if(Frag==1){
			this.pointText.GetComponent<Text> ().text = myscore.ToString();
		}
		Frag=0;
	}

	//スコアを加算する関数
	public void Score(int point){
		myscore += point;	
	}


	//衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other) {
		Frag = 1;
		switch(other.gameObject.tag){
			case "SmallStarTag":
				Score(5);
				break;
			case "LargeStarTag":
				Score(30);
				break;
			case "SmallCloudTag":
				Score(20);
				break;
			case "LargeCloudTag":
				Score(50);
				break;
		}
	}
}
