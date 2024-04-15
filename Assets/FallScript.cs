using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    public GameObject characterController;
    private Vector3 characterDefaultPosition;


    // Start is called before the first frame update
    void Start()
    {
        characterDefaultPosition = characterController.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(characterDefaultPosition);
            characterController.transform.position = characterDefaultPosition;
            other.gameObject.transform.position = characterDefaultPosition;
        }
    }
}
