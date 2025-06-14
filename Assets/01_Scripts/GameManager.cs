using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Character Player { get; private set; }
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        SetData();
    }

    public void SetData()//플레이어 초기 정보
    {
        Player = new Character
            ("A", "초록 도마뱀", "초록색 도마뱀이다. 귀여워보이지만 무시무시한 힘을 갖고있다" 
                ,10, 1,20,20,40,5,30000,new List<Item>(),new Dictionary<ItemType, UISlot>());
    }
}
