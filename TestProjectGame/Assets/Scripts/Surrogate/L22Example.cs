using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Surrogate
{
public class L22Example : MonoBehaviour
{
    private Storage storage;
    private GameData gameData;
    public GameObject player;

    private void Start() {
        
        storage = new Storage();
        gameData = (GameData) storage.Load(new GameData());
        
    }

    public void Save()
    {
        gameData.positionPlayer = player.transform.position;
        gameData.rotationPlayer = player.transform.rotation;
        gameData.healthPlayer = player.GetComponent<HealthBar>().health;
        storage.Save(gameData);
        Debug.Log("GameSaved");

    }
    public void Load()
    {
        player.transform.position = gameData.positionPlayer;
        player.transform.rotation = Quaternion.identity; 
        player.GetComponent<HealthBar>().health = gameData.healthPlayer;
        gameData = (GameData) storage.Load(new GameData());
        Debug.Log("Loaded");
    }
}
}