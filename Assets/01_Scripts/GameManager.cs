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
    }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        Player = new Character
            ("A", "초록 도마뱀", "초록색 도마뱀이다. 귀여워보이지만 무시무시한 힘을 갖고있다" 
                ,10, 0,20,20,40,5,new List<Item>());
    }
}
