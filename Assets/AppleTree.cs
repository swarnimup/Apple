using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Inscribed")]
    // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which the AppleTree moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that the AppleTree will change directions
    public float changeDirChance = 0.1f;

    // Seconds between Apples instantiations
    public float appleDropDelay = 1f;

    void Start() {
        // Start dropping apples
        Invoke( "DropApple", 2f );
    }
    void DropApple(){
        GameObject apple = Instantiate<GameObject>( applePrefab );
        apple.transform.position = transform.position;
        Invoke( "DropApple" , appleDropDelay );
    }

    void Update() {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //changing direction
        if (pos.x<-leftAndRightEdge){
            speed = Mathf.Abs(speed);
        } else if ( pos.x > leftAndRightEdge){
            speed = -Mathf.Abs( speed);
       // } else if ( Random.value < changeDirChance){
       //   speed *= -1;
        }
       
    }
    void FixedUpdate(){
        if (Random.value < changeDirChance){
            speed *= -1;
        }
    }
 public GameObject branchPrefab; // Add this line

void DropBranch()
{
    GameObject branch = Instantiate<GameObject>(branchPrefab);
    branch.transform.position = transform.position;
    Invoke("DropBranch", appleDropDelay * Random.Range(5f, 10f)); // Less frequent than apples
}

}
