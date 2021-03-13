using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private new string tag;

    [SerializeField]
    private GameObject cardPrefab;
    [SerializeField]
    private GameObject card;

    [SerializeField]
    private GameObject[] spawnPoints;

    [SerializeField]
    private GameObject selectedSpawnPoint;
    // Start is called before the first frame update
    void Start() => ConfirmAnchorPosition();

    private void ConfirmAnchorPosition()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ConfirmAnchorPosition(Vector2 screenPosition)
    {
        spawnPoints = GameObject.FindGameObjectsWithTag(tag);
        int rand = UnityEngine.Random.Range(0, spawnPoints.Length);
        selectedSpawnPoint = spawnPoints[rand];
        card = Instantiate(cardPrefab, selectedSpawnPoint.transform.position, selectedSpawnPoint.transform.localRotation);
    }
}
