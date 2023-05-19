using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reader : MonoBehaviour
{
    public TextAsset TextJson;
    [System.Serializable]
    public class Respawn
    {
        public int x;
        public int y;
        public int z;
    }

    public class RespawnList
    {
        public Respawn[] respawn;
    }
    
    public RespawnList myRespawnList = new RespawnList();

    void Start()
    {
        
    }

    void Update()
    {
        myRespawnList = JsonUtility.FromJson<RespawnList>(TextJson.text);
    }
}
