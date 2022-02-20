using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallSpawner : MonoBehaviour
{
    public CannonBallScript cannonballPrefab;
    public float cannonballSpeed;
    private float time = 0;
    public float cannonballDelay;

    public bool fromLeft = false;
    public bool shoot;

    private Vector2 dir2;
    // Start is called before the first frame update
    void Start()
    {
        dir2 = new Vector2(cannonballSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot == true)
        {
            if (time < Time.time)
            {
                CannonBallScript cannonball=Instantiate(cannonballPrefab, transform.position, transform.rotation) as CannonBallScript;
                cannonball.dir = dir2;
                if (fromLeft == true)
                {
                    cannonball.transform.rotation = Quaternion.Euler(0, 0, 0);
                }else
                {
                    cannonball.transform.rotation = Quaternion.Euler(0, 0, 180); 
                }
                time = Time.time + cannonballDelay;
            }
        }
    }
}
