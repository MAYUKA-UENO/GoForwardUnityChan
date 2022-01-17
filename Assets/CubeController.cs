using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //地面のいち
    private float groundLevel = -3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);


        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {

            Destroy(gameObject);

        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        //　キューブと地面に衝突した場合
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")
        {
            //効果音を再生
            GetComponent<AudioSource>().Play();

        }


    }
}
