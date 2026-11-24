using UnityEngine;

public class LocationSwitcher : MonoBehaviour
{
   public Transform[] locations;
    public float moveSpeed = 5f;
    public int currentLocation = 0;

    void Start()
    {
        transform.position = locations[currentLocation].position;
        transform.rotation = locations[currentLocation].rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            NextLocation();
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            PreviousLocation();
        }
    }

    void NextLocation()
    {
        if (currentLocation < locations.Length - 1)
        {
            currentLocation++;
            MoveToLocation();
        }
    }
    void PreviousLocation()
    {
        if (currentLocation > 0)
        {
            currentLocation--;
            MoveToLocation();
        }
    }
    void MoveToLocation()
    {
        transform.position = locations[currentLocation].position;
        transform.rotation = locations[currentLocation].rotation;
    }
}
