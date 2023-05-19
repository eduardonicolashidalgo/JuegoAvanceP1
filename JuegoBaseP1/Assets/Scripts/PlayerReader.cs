using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReader : MonoBehaviour
{
    public TextAsset TextJson;
    [System.Serializable]
    public class Player
    {
        public int hp;
        public string itemscollected;
    }

    public class PlayerList
    {
        public Player[] player;
    }
    
    public PlayerList myPlayerList = new PlayerList();

    void Start()
    {
        
    }

    void Update()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(TextJson.text);
    }
}
