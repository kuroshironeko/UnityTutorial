using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public float speed = 10.0f;    //これを追加

	// Use this for initialization
	void Start () {
		//以下を追加
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward + transform.right) * speed,
			ForceMode.VelocityChange);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "Block") {
			//相手のタグがBallならば、自分を消す
			Destroy(collision.gameObject);
		}
		// 追加
		this.GetComponent<Rigidbody>().velocity = this.GetComponent<Rigidbody>().velocity.normalized * 10;
	}
}