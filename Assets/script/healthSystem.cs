using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthSystem : MonoBehaviour {

    public int health; // 현재 실제로 가지고 있는 체력량
    public int numOfHearts; // 하트의 테두리 개수

    public Image[] hearts; // 하트 이미지들을 배열로 나열 
    public Sprite fullHeart; // 꽉찬 모양의 하트 UI 를 연결 
    public Sprite emptyHeart; // 테두리 모양의 하트 UI 를 연결

	// Update is called once per frame
	void Update () {
		
        if (health > numOfHearts)
        {
            health = numOfHearts; // 실제 체력량이 테두리 개수보다 많아지면 테두리 갯수에 맞도록 설정
        }

        for (int i = 0; i < hearts.Length; i++) //하트 이미지의 배열 길이 만큼 반복
        {
            if (i < health) // 현재 체력량 까지만 full 하트로 표현하고, 남은 하트들은 테두리 하트로 표현
            {
                hearts[i].sprite = fullHeart; 
            }else{
                hearts[i].sprite = emptyHeart; 
            }

           /* if (i < numOfHearts) // 내가 설정한 테두리 하트 갯수 < 배열에 넣은 하트 이미지 갯수 일시 테두리 하트 갯수만큼만 UI가 보여져야 하므로
            { 
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false; // 내가 설정한 테두리 하트의 갯수보다 배열에 넣은 하트 이미지 갯수가 커지면 넘치는 하트들을 숨겨야함.
            } */

        }

        if ( health == 0 )
        {
            Time.timeScale = 0; // Time.timeScale 은 전체 게임의 속도를 1로 보는 것. 1 : not pause, 0 : pause
        }

	}


    private void OnTriggerEnter2D(Collider2D col) // 불기둥에 닿으면 
    {
        //하트의 개수가 감소하고
        if (col.gameObject.tag == "damCol")
        {
            health -= 1;
        }
 
        // 하트의 개수가 0 이 되면 게임을 멈춘다.

        if (col.gameObject.tag == "cliff")
        {
            health = 0;

        } 

    }


}
