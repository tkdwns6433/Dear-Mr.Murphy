using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerMove : MonoBehaviour
{

    public float smoothTimeX, smoothTimeY;
    public Vector2 velocity;
    public GameObject player;
    public Vector2 minPos, maxPos; // 최소 최대 포지션을 인스펙터 창에서 직접 입력
    //public bool bound;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {


        // Mathf.SmoothDamp 는 값을 천천히 증가시키는 메서드 ( 현재 위치, 타겟위치, 현재 속도, ? )
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        // 위의 함수로 값을 천천히 이동시킨 위치에 카메라를 계속 이동
        transform.position = new Vector3(posX + 2 , posY, transform.position.z);

       /* if (bound)
        {
            // Mathf.Clamp ( 현재값, 최소값, 최대값 ) ; 현재값이 최대값까지만 반환해주고 최솟값보다 작으면 그 최솟값까지만 반환
            // 즉 현재 카메라의 x , y 위치 를 최소 최대 값으로 범위 조정. z 값은 고정한다.
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPos.x, maxPos.x),
                                      Mathf.Clamp(transform.position.y, minPos.y, maxPos.y),
                                      Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z));


        } */

    }
}
