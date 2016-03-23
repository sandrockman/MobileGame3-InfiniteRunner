using UnityEngine;
using System.Collections;

public class ObstacleControllerScript : MonoBehaviour {

    public Rigidbody2D obstaclePrefab;
    float speed = -3.0f;
    GameObject playerObj;

	// Use this for initialization
	void Start () {

        Invoke("SpawnObstacle", 3f);

	}
	
	void SpawnObstacle ()
    {
        //spawn an obstacle at x 10, y -4 to zero
        Vector3 spawnPos = new Vector3(10, Random.Range(-4, 0), 0);
        GameObject tempObstacle = Instantiate(obstaclePrefab, spawnPos, Quaternion.Euler(Vector3.zero)) as GameObject;
        tempObstacle.name = "Obstacle(clone)";
        tempObstacle.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.name == "Ninja")
        {
            Time.timeScale = 0;
            Destroy(other.gameObject);

        }
}
