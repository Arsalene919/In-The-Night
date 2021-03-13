using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardBehaviour : MonoBehaviour
{
    // Use this for initialization

    public GameObject[] ObjectsToSpawn;
    List<GameObject> SpawnedObjects;
    Vector3 SpawnPosition = new Vector3(-0.2f, 0.3f, 1.5f);
    int CurrentCardIndex = 0;

    // Update is called once per frame
    public void FixedUpdate()
    {
        //probleme
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            SpawnCards();
        }

        if (Input.GetMouseButtonDown(0))
        {
            SpawnCards();
        }
    }

    void SpawnCards()
    {
        if (SpawnPosition.y < -0.4)
        {
            Debug.Log("Screen limit reached");
            return;
        }
        Instantiate(ObjectsToSpawn[CurrentCardIndex], SpawnPosition, Quaternion.identity);
        SpawnPosition.x += 0.2f;
        if (SpawnPosition.x > 0.2f)
        {
            SpawnPosition.y -= 0.3f;
            SpawnPosition.x = -0.2f;
        }
        ++CurrentCardIndex;
        if (CurrentCardIndex == ObjectsToSpawn.Length - 1)
        {
            CurrentCardIndex = 0;
        }
    }
}